using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Persistencia
{
    public class pAsisTec : clsPersistencia
    {
        public void altaAsisTec(eAsisTec asisTec)
        {
            string consultaSQL = "INSERT INTO asistente_tecnico (id_asistente) SELECT id_usuario FROM usuario WHERE ci = '" + asisTec.ci + "';";
            ejecutarSQL(consultaSQL);
        }
    }
}
