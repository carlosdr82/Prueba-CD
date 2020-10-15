using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CLIENTE
    {
        public long ID { get; set; }
        public int ID_TIPO_DOCUMENTO { get; set; }
        public string NUMERO_DOCUMENTO { get; set; }
        public string NOMBRE { get; set; }
        public string CORREO { get; set; }
    }
}
