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
        string consultaSQL;
        MySqlDataReader resultado;

        public eUsuario login(string nombre, string clave)
        {
            eUsuario usuario = null;
            consultaSQL = "SELECT * FROM usuario WHERE ci='" + nombre + "' AND clave='" + clave + "';";
            resultado = ejecutarYdevolver(consultaSQL);
            if (resultado.Read())
            {
                usuario = recrearP(resultado);
            }
            return usuario;
        }

        public void altaUsuario(eUsuario usuario)
        {
            consultaSQL = "INSERT INTO usuario (nombre, apellido, ci, clave) VALUES ('" + usuario.nombre + "', '" + usuario.apellido +
                                 "', '" + usuario.ci + "', '" + usuario.clave + "');";
            ejecutarSQL(consultaSQL);
        }

        public void modificarUsuario(string id, string atributo, string valor)
        {
            consultaSQL = "UPDATE usuario SET " + atributo + " = '" + valor + "' WHERE id_usuario='" + id +"';";
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

        public List<eUsuario> listarUsuario(int index)
        {
            List<eUsuario> _usuarios = new List<eUsuario>();

            switch (index)
            {
                case 0:     //Todos
                    this.consultaSQL = "SELECT * FROM usuario ;";
                    this.resultado = ejecutarYdevolver(this.consultaSQL);
                    while (this.resultado.Read())
                    {
                        _usuarios.Add(recrearP(this.resultado));
                    }
                    break;

                case 1:     //Alumnos
                    this.consultaSQL = "SELECT * FROM usuario INNER JOIN cliente ON usuario.id_usuario=cliente.id_cliente WHERE cliente.docente=false;";
                    this.resultado = ejecutarYdevolver(this.consultaSQL);
                    while (this.resultado.Read())
                    {
                        _usuarios.Add(recrearP(this.resultado));
                    }
                    break;
                case 2:     //Docentes
                    this.consultaSQL = "SELECT * FROM usuario INNER JOIN cliente ON usuario.id_usuario=cliente.id_cliente WHERE cliente.docente=true;";
                    this.resultado = ejecutarYdevolver(this.consultaSQL);
                    while (this.resultado.Read())
                    {
                        _usuarios.Add(recrearP(this.resultado));
                    }
                    break;
                case 3:     //Asistentes Tecnicos
                    this.consultaSQL = "SELECT * FROM usuario INNER JOIN asistente_tecnico ON usuario.id_usuario=asistente_tecnico.id_asistente;";
                    this.resultado = ejecutarYdevolver(this.consultaSQL);
                    while (this.resultado.Read())
                    {
                        _usuarios.Add(recrearP(this.resultado));
                    }
                    break;
            }

            return _usuarios;
        }

        public void bajaUsuario(string id)
        {
            consultaSQL = "DELETE FROM usuario WHERE id_usuario='" + id + "';";
            ejecutarSQL(consultaSQL);
        }
    }
}
