using SistemaProjectSchool.Application.People.DocumentTypes.Features.Restore;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    internal sealed class RestoreDocumentTypeWrapperController : IRestoreDocumentTypeController
    {
        private readonly IRestoreDocumentTypeInputPort _inputPort;

        public RestoreDocumentTypeWrapperController(IRestoreDocumentTypeInputPort inputPort)
        {
            _inputPort = inputPort;
        }

        public async ValueTask Handle(Guid documentTypeId)
        {
            await _inputPort.Handle(documentTypeId);
        }
    }
}
