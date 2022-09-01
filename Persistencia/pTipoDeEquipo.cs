using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using MySql.Data.MySqlClient;

namespace Persistencia
{
    public class pTipoDeEquipo : clsPersistencia
    {
        public void altaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            string consultaSQL = "INSERT INTO tipo (nombre, subtipo) VALUES ('" + tipo.nombre + "', '" + tipo.subtipo + "');";
            ejecutarSQL(consultaSQL);
        }

        private eTipoDeEquipo recrearT(MySqlDataReader resultado)
        {
            eTipoDeEquipo tipo = new eTipoDeEquipo();
            tipo.id = resultado.GetInt32("id_tipo");
            tipo.nombre = resultado.GetString("nombre");
            tipo.subtipo = resultado.GetString("subtipo");

            return tipo;
        }
    }
}
