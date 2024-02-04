using SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll;

namespace SistemaProjecrSchool.Infrastructure.People.DocumentTypes.Controllers
{
    internal sealed class GetAllDocumentTypeWrapperController : IGetAllDocumentTypeController
    {
        private readonly IGetAllDocumentTypeInputPort _inputPort;
        private readonly IGetAllDocumentTypePresenter _presenter;

        public GetAllDocumentTypeWrapperController(
            IGetAllDocumentTypeInputPort inputPort,
            IGetAllDocumentTypePresenter presenter)
        {
            _inputPort = inputPort;
            _presenter = presenter;
        }

        public async ValueTask<IReadOnlyList<GetAllDocumentTypeResponse>> Handle()
        {
            await _inputPort.Handle();

            return _presenter.Response;
        }
    }
}
