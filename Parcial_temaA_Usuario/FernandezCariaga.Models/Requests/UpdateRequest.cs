using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezCariaga.Models.Requests
{
    public class UpdateRequest : CreateRequest
    {
        public Guid id { get; set; }
    }
}
