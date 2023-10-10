using FluentValidation;
using projeto_farmacia.Model;

namespace projeto_farmacia.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Tipo)
                .NotEmpty()
                .MaximumLength(255);

        }
    }
}
