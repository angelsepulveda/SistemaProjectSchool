
using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Update
{
    internal sealed class UpdateDocumentTypeUseCase : IUpdateDocumentTypeInputPort
    {
        private readonly IDocumentTypeQueryRepository _documentTypeQueryRepository;
        private readonly IDocumentTypeCommandRepository _documentTypeCommandRepository;
        private readonly IUpdateDocumentTypeOutputPort _outputPort;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateDocumentTypeUseCase(
            IDocumentTypeQueryRepository documentTypeQueryRepository, 
            IDocumentTypeCommandRepository documentTypeCommandRepository, 
            IUpdateDocumentTypeOutputPort outputPort,
            IUnitOfWork unitOfWork)
        {
            _documentTypeQueryRepository = documentTypeQueryRepository;
            _documentTypeCommandRepository = documentTypeCommandRepository;
            _outputPort = outputPort;
            _unitOfWork = unitOfWork;
        }

        public async ValueTask Handle(UpdateDocumentTypePayload payload)
        {
            DocumentType? documentType = await _documentTypeQueryRepository.GetById(new DocumentTypeId(payload.Id));

            if (documentType == null) throw new BadRequestException("El documentType no se encuentra registrado");

            documentType.Update(name: payload.Name, description: payload.Description);

            _documentTypeCommandRepository.Update(documentType);

            int result = await _unitOfWork.Complete();

            if (result <= 0) throw new BadRequestException();

            await _outputPort.Handle(documentType);

        }
    }
}
