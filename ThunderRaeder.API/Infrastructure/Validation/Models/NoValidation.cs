using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThunderRaeder.API.Infrastructure.Validation.Models
{
    public class NoValidation : IValidationModel
    {
        public void Set(object request)
        {
            
        }
    }
}
