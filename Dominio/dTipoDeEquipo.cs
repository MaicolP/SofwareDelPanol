using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Persistencia;

namespace Dominio
{
    public class dTipoDeEquipo
    {
        public void altaTipoDeEquipo(eTipoDeEquipo tipo)
        {
            pTipoDeEquipo unTipo = new pTipoDeEquipo();
            unTipo.altaTipoDeEquipo(tipo);
        }
    }
}
