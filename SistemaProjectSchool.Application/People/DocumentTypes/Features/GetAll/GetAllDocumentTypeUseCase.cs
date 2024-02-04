using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.GetAll
{
    internal sealed class GetAllDocumentTypeUseCase : IGetAllDocumentTypeInputPort
    {   
        private readonly IGetAllDocumentTypeOutputPort _outputPort;
        private readonly IDocumentTypeQueryRepository _documentTypeQueryRepository;

        public GetAllDocumentTypeUseCase(
            IGetAllDocumentTypeOutputPort outputPort,
            IDocumentTypeQueryRepository documentTypeQueryRepository)
        {
            _outputPort = outputPort;
            _documentTypeQueryRepository = documentTypeQueryRepository;
        }

        public async ValueTask Handle()
        {
            List<DocumentType> documentTypes = await _documentTypeQueryRepository.GetAll();

            await _outputPort.Handle(documentTypes);
        }
    }
}
