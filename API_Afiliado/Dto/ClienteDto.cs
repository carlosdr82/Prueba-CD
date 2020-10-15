using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class ClienteDto
    {
        public class InGetByIdCliente
        {
            public string IdCliente { get; set; }
        }

        public class OutGetByIDCliente:BaseOut
        {
            public long Id { get; set; }
            public string TipoDocumento { get; set; }
            public string NumeroDocumento { get; set; }
            public string Nombre { get; set; }
            public string Correo { get; set; }
        }

       
    }
}
