using Newtonsoft.Json;
using System.Net;

namespace SistemaProjectSchool.WebApi.Errors
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _environment;

        public ExceptionHandlerMiddleware(RequestDelegate next, IWebHostEnvironment environment)
        {
            _next = next;
            _environment = environment;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";

                int statusCode = (int)HttpStatusCode.InternalServerError;

                string result = string.Empty;

                switch (ex)
                {
                    case NotFoundException notFoundException:
                        statusCode = (int)HttpStatusCode.NotFound;
                        break;

                    case NoContentException notContentException:
                        statusCode = (int)HttpStatusCode.NoContent;
                        break;
                    case BadRequestException badRequestException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        break;

                    case DomainException domainException:
                        statusCode = (int)HttpStatusCode.BadRequest;
                        break;

                    default:
                        statusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }

                if (string.IsNullOrEmpty(result))
                {
                    string message = ex.Message;
                    bool isDevelopment = _environment.IsDevelopment();
                    result = JsonConvert.SerializeObject(
                        new CodeErrorException(statusCode, isDevelopment ? message : string.Empty, null));
                }

                context.Response.StatusCode = statusCode;

                if (statusCode != (int)HttpStatusCode.NoContent)
                    await context.Response.WriteAsync(result);
            }
        }
    }
}
