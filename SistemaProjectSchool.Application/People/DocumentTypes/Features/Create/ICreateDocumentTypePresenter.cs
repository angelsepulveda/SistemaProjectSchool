namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Create
{
    public interface ICreateDocumentTypePresenter : ICreateDocumentTypeOutputPort
    {
        Guid DocumentTypeId { get; }
    }
}
