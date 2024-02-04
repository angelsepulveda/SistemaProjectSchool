using SistemaProjectSchool.Application.People.DocumentTypes.Features.Update;

namespace SistemaProjectSchool.WebApi.Modules.People.DocumentTypes
{
    public class UpdateDocumentTypeValidator : AbstractValidator<UpdateDocumentTypePayload>
    {
        public UpdateDocumentTypeValidator() 
        {
            RuleFor(p => p.Id).NotNull().WithMessage("El id es requerido");

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("El nombre es requerido")
                .MaximumLength(50).WithMessage("El nombre no puede superar 50 caracteres");

            RuleFor(p => p.Description).MaximumLength(256)
                .WithMessage("La descripcion no puede superar los 256 caracteres");
        }
    }
}
