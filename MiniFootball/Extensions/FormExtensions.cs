using MiniFootball.Forms;
using MiniFootball.Infrastructures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniFootball.Extensions
{
    public static class FormExtensions
    {
        public static Tuple<bool,List<ValidationResult>> CustomValidator(this Form form,object obj)
        {
            ValidationContext context = new ValidationContext(obj);
            List<ValidationResult> results = new List<ValidationResult>();
             bool isValid =  Validator.TryValidateObject(obj, context, results, true);
            return Tuple.Create(isValid, results);
        }
        
        
    }
}
