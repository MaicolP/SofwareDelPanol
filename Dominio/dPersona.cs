using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dPersona
    {
        public ePersona login(string nombre, string clave)
        {
            pPersona unP = new pPersona();
            return unP.login(nombre, clave);
        }
    }
}
