using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dUsuario
    {
        public eUsuario login(string nombre, string clave)
        {
            pUsuario unU = new pUsuario();
            return unU.login(nombre, clave);
        }
    }
}
