using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pPersona : clsPersistencia
    {
        public ePersona login(string nombre, string clave)
        {
            ePersona persona = null;
            string consultaSQL = "SELECT * FROM persona WHERE ci='" + nombre + "' AND clave='" + clave + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            if (resultado.Read())
            {
                persona = recrearP(resultado);
            }
            return persona;
        }

        private ePersona recrearP(MySqlDataReader resultado)
        {
            ePersona persona = new ePersona();
            persona.id = Convert.ToInt16(resultado.GetString("id"));
            persona.ci = resultado.GetString("ci");
            persona.nombre = resultado.GetString("nombre");
            persona.apellido = resultado.GetString("apellido");
            persona.clave = resultado.GetString("clave");

            return persona;
        }
    }
}
