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
            string consultaSQL = "SELECT * FROM usuario WHERE ci='" + nombre + "' AND clave='" + clave + "';";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            if (resultado.Read())
            {
                usuario = recrearP(resultado);
            }
            return usuario;
        }

        public void altaUsuario(eUsuario usuario)
        {
            string consultaSQL = "INSERT INTO usuario (nombre, apellido, ci, clave) VALUES ('" + usuario.nombre + "', '" + usuario.apellido +
                                 "', '" + usuario.ci + "', '" + usuario.clave + "');";
            ejecutarSQL(consultaSQL);
        }

        private eUsuario recrearP(MySqlDataReader resultado)
        {
            eUsuario persona = new eUsuario();
            persona.id = Convert.ToInt32(resultado.GetString("id_usuario"));
            persona.ci = resultado.GetString("ci");
            persona.nombre = resultado.GetString("nombre");
            persona.apellido = resultado.GetString("apellido");
            persona.clave = resultado.GetString("clave");

            return persona;
        }

        public List<eUsuario> listarUsuario()
        {
            List<eUsuario> _usuarios = new List<eUsuario>();
            string consultaSQL = "SELECT * FROM usuario ;";
            MySqlDataReader resultado = ejecutarYdevolver(consultaSQL);
            while (resultado.Read())
            {
                _usuarios.Add(recrearP(resultado));
            }
            return _usuarios;
        }
    }
}
