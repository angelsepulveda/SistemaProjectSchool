using SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    internal sealed class DeleteDocumentTypeWrapperController : IDeleteDocumentTypeController
    {
        private readonly IDeleteDocumentTypeInputPort _inputPort;

        public DeleteDocumentTypeWrapperController(IDeleteDocumentTypeInputPort inputPort)
        {
            _inputPort = inputPort;
        }

        public async ValueTask Handle(Guid documentTypeId)
        {
            await _inputPort.Handle(documentTypeId);
        }
    }
}
