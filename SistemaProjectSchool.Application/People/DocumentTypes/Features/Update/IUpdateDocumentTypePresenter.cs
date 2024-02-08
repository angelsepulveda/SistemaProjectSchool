namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Update
{
    public interface IUpdateDocumentTypePresenter : IUpdateDocumentTypeOutputPort
    {
        Guid Response { get; }
    }
}
