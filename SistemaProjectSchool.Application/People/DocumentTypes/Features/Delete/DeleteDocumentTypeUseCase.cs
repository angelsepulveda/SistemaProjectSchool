using SistemaProjectSchool.Domain.People.DocumentTypes;

namespace SistemaProjectSchool.Application.People.DocumentTypes.Features.Delete
{
    internal sealed class DeleteDocumentTypeUseCase : IDeleteDocumentTypeInputPort
    {
        private readonly IDocumentTypeQueryRepository _documentTypeQueryRepository;
        private readonly IDocumentTypeCommandRepository _documentTypeCommandRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteDocumentTypeUseCase(
            IDocumentTypeQueryRepository documentTypeQueryRepository, 
            IDocumentTypeCommandRepository documentTypeCommandRepository, 
            IUnitOfWork unitOfWork)
        {
            _documentTypeQueryRepository = documentTypeQueryRepository;
            _documentTypeCommandRepository = documentTypeCommandRepository;
            _unitOfWork = unitOfWork;
        }

        public async ValueTask Handle(Guid payload)
        {
            DocumentType? documentType = await _documentTypeQueryRepository.GetById(new DocumentTypeId(payload));

            if (documentType == null) throw new BadRequestException("El documentType no se encuentra registrado");

            documentType.Delete();

            _documentTypeCommandRepository.Update(documentType);

            int result = await _unitOfWork.Complete();

            if (result <= 0) throw new BadRequestException();

        }
    }
}
