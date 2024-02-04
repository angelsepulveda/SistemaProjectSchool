namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll
{
    public sealed record GetAllDocumentTypeResponse(Guid Id, string Name, string? Description, bool IsDelete);
}
