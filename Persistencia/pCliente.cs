using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public class pCliente : clsPersistencia
    {
        public void altaCliente(eCliente cliente)
        {
            string consultaSQL = "INSERT INTO cliente (id_cliente) SELECT id_usuario FROM usuario WHERE ci = '" + cliente.ci + "';" +
                                 "UPDATE cliente SET docente=" + cliente.docente.ToString() + " WHERE id_cliente =" +
                                 "(SELECT id_usuario FROM usuario WHERE ci='" + cliente.ci + "');";
            ejecutarSQL(consultaSQL);
        }
    }
}
