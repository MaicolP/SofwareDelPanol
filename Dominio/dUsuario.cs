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
        private pUsuario unU = new pUsuario();

        public eUsuario login(string nombre, string clave)
        {
            return unU.login(nombre, clave);
        }

        public void altaUsuario(eUsuario usuario)
        {
            unU.altaUsuario(usuario);
        }

        public List<eUsuario> listarUsuario(int index)
        {
            return unU.listarUsuario(index);
        }

        public void bajaUsuario(string id)
        {
            unU.bajaUsuario(id);
        }

        public void modificarUsuario(string id, string atributo, string valor)
        {
            unU.modificarUsuario(id, atributo, valor);
        }
    }
}
