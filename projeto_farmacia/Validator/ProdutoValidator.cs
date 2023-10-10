using FluentValidation;
using projeto_farmacia.Model;

namespace projeto_farmacia.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MaximumLength(1000);

            RuleFor(p => p.DataValidade)
                .NotEmpty();

            RuleFor(p => p.Foto)
                .NotEmpty()
                .MaximumLength(2000);

        }
    }
}
