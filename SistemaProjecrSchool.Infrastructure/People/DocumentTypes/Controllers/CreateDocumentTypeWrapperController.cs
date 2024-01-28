using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    internal sealed class CreateDocumentTypeWrapperController : ICreateDocumentTypeController
    {
        private readonly ICreateDocumentTypePresenter _presenter;
        private readonly ICreateDocumentTypeInputPort _inputPort;

        public CreateDocumentTypeWrapperController(
            ICreateDocumentTypePresenter presenter,
            ICreateDocumentTypeInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<Guid> Handle(CreateDocumentTypePayload payload)
        {
           await _inputPort.Handle(payload);

           return _presenter.DocumentTypeId;
        }
    }
}
