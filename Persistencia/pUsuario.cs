using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pUsuario : clsPersistencia
    {
        public eUsuario login(string nombre, string clave)
        {
            eUsuario usuario = null;
            string consultaSQL = "SELECT * FROM persona WHERE ci='" + nombre + "' AND clave='" + clave + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            if (resultado.Read())
            {
                usuario = recrearP(resultado);
            }
            return usuario;
        }

        private eUsuario recrearP(MySqlDataReader resultado)
        {
            eUsuario persona = new eUsuario();
            persona.id = Convert.ToInt16(resultado.GetString("id"));
            persona.ci = resultado.GetString("ci");
            persona.nombre = resultado.GetString("nombre");
            persona.apellido = resultado.GetString("apellido");
            persona.clave = resultado.GetString("clave");

            return persona;
        }
    }
}
