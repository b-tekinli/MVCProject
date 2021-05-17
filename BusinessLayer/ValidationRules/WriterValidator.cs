using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adını boş bırakamazsınız!");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar soyadını boş bırakamazsınız!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş bırakamazsınız!").Must(x => x.Contains('a')).WithMessage("Hakkımda kısmında 'a' karakteri kullanmalısınız!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz!");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz!");
        }
    }
}
