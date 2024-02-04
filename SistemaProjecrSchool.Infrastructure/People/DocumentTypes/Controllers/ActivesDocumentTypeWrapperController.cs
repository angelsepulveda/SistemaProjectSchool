using SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    internal sealed class ActivesDocumentTypeWrapperController : IActivesDocumentTypeController
    {
        private readonly IActivesDocumentTypePresenter _presenter;
        private readonly IActivesDocumentTypeInputPort _inputPort;

        public ActivesDocumentTypeWrapperController(
            IActivesDocumentTypePresenter presenter,
            IActivesDocumentTypeInputPort inputPort)
        {
            _presenter = presenter;
            _inputPort = inputPort;
        }

        public async ValueTask<IReadOnlyList<ActivesDocumentType>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.Response;
        }
    }
}
