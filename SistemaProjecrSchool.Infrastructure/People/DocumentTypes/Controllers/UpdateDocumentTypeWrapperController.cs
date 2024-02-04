using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    internal sealed class UpdateDocumentTypeWrapperController : IUpdateDocumentTypeController
    {
        private readonly IUpdateDocumentTypeInputPort _inputPort;
        private readonly IUpdateDocumentTypePresenter _presenter;

        public UpdateDocumentTypeWrapperController(
            IUpdateDocumentTypeInputPort inputPort, 
            IUpdateDocumentTypePresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<Guid> Handle(UpdateDocumentTypePayload payload)
        {
            await _inputPort.Handle(payload);

            return _presenter.Response;
        }
    }
}
