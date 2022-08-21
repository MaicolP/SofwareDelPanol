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

        public void altaUsuario(eUsuario usuario)
        {
            pUsuario unU = new pUsuario();
            unU.altaUsuario(usuario);
        }

        public List<eUsuario> listarUsuario()
        {
            pUsuario unU = new pUsuario();
            return unU.listarUsuario();
        }

        public void bajaUsuario(string id)
        {
            pUsuario unU = new pUsuario();
            unU.bajaUsuario(id);
        }
    }
}
