using SistemaProjectSchool.Application.People.DocumentTypes.Features.Create;

namespace SistemaProjectSchool.WebApi.Modules.People.DocumentTypes
{
    public class CreateDocumentTypeValidator : AbstractValidator<CreateDocumentTypePayload>
    {
        public CreateDocumentTypeValidator() 
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("El nombre es requerido")
                .MaximumLength(50).WithMessage("El nombre no puede superar 50 caracteres");

            RuleFor(p => p.Description).MaximumLength(256)
                .WithMessage("La descripcion no puede superar los 256 caracteres");

        }
    }
}
