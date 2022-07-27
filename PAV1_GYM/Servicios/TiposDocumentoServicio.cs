using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class TiposDocumentoServicio
    {
        private TiposDocumentoRepositorio tiposDocumentoRepositorio;

        public TiposDocumentoServicio()
        {
            tiposDocumentoRepositorio = new TiposDocumentoRepositorio();
        }

        public List<TipoDocumento> GetTiposDocumento()
        {
            return tiposDocumentoRepositorio.GetTiposDocumento();
        }
    }
}
