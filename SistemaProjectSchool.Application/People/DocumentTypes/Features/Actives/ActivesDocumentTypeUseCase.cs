using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Actives
{
    internal sealed class ActivesDocumentTypeUseCase : IActivesDocumentTypeInputPort
    {
        private readonly IActivesDocumentTypesOutputPort _outputPort;
        private readonly IDocumentTypeQueryRepository _documentTypeQueryRepository;

        public ActivesDocumentTypeUseCase(
            IActivesDocumentTypesOutputPort outputPort,
            IDocumentTypeQueryRepository documentTypeQueryRepository)
        {
            _outputPort = outputPort;
            _documentTypeQueryRepository = documentTypeQueryRepository;
        }

        public async ValueTask Handle()
        {
            List<DocumentType> documentTypes = await _documentTypeQueryRepository.Actives();

            await _outputPort.Handle(documentTypes);
        }
    }
}
