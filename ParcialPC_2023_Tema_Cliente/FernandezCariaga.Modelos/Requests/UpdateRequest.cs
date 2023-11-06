using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FernandezCariaga.Modelos.Requests
{
    public class UpdateRequest : CreateRequest
    {
        public Guid Id { get; set; }
    }
}
