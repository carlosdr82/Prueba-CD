using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class TipoDocumentoDto
    {
        public class InGetByIdTipoDocumento
        {
            public string IdTipo { get; set; }
        }

        public class OutGetByIdTipoDocumento: BaseOut
        {
            public int Id { get; set; }
            public string Descripion { get; set; }
        }
    }
}
