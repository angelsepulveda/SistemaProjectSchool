using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Create
{
    internal sealed class CreateDocumentTypeUseCase : ICreateDocumentTypeInputPort
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ICreateDocumentTypeOutputPort _outputPort;
        private readonly IDocumentTypeCommandRepository _documentTypeCommandRepository;

        public CreateDocumentTypeUseCase(
            IUnitOfWork unitOfWork, 
            ICreateDocumentTypeOutputPort outputPort, 
            IDocumentTypeCommandRepository documentTypeCommandRepository)
        {
            _unitOfWork = unitOfWork;
            _outputPort = outputPort;
            _documentTypeCommandRepository = documentTypeCommandRepository;
        }

        public async ValueTask Handle(CreateDocumentTypePayload payload)
        {
            DocumentType documentType = DocumentType.Create(payload.Name, payload.Description);

            _documentTypeCommandRepository.Save(documentType);

            int result = await _unitOfWork.Complete();

            if (result <= 0) throw new BadRequestException();

            await _outputPort.Handle(documentType);
        }
    }
}
