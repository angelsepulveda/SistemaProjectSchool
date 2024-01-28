using SistemaProjectSchool.WebApi.Shared;

WebApplication.CreateBuilder(args)
    .ConfigurareWebApplicationServices()
    .ConfigureWebApiMiddlewares()
    .Run();