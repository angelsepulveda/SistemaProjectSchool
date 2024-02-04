namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Update
{
    public sealed record UpdateDocumentTypePayload(Guid Id,string Name, string? Description);
}
