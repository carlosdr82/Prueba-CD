using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dao;
using Model;

namespace Blo
{
    public class ClienteBlo
    {
        public List<CLIENTE> GetAll()
        {
            ClienteDao cliente = new ClienteDao();
            return cliente.GetAll();
        }

        public CLIENTE GetById(long id)
        {
            ClienteDao cliente = new ClienteDao();
            return cliente.GetById(id);
        }

        public void Insert(CLIENTE data)
        {
            ClienteDao cliente = new ClienteDao();
            cliente.Insert(data);
        }

        public void Update(CLIENTE data)
        {
            ClienteDao cliente = new ClienteDao();
            cliente.Update(data);
        }

        public void Delete(long id)
        {
            ClienteDao cliente = new ClienteDao();
            cliente.Delete(id);
        }
    }
}
