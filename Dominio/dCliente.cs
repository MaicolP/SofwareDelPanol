using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dCliente
    {
        public void altaCliente(eCliente cliente)
        {
            pCliente unC = new pCliente();
            unC.altaCliente(cliente);
        }
    }
}
