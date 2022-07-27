using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAV1_GYM.Entidades;
using PAV1_GYM.RepositoriosBD;

namespace PAV1_GYM.Servicios
{
    public class FacturasServicio
    {
        private FacturasRepositorio facturasRepositorio;

        public FacturasServicio()
        {
            facturasRepositorio = new FacturasRepositorio();
        }

        public List<int> GetNroFacturas()
        {
            return facturasRepositorio.GetNroFacturas();
        }

        public bool RegistrarFactura(Factura factura, Dictionary<int, DetalleFactura> listDf)
        {
            return facturasRepositorio.RegistrarFactura(factura, listDf);
        }

        public void EliminarFactura(int nroFactura)
        {
            if (!facturasRepositorio.EliminarFactura(nroFactura))
                throw new ApplicationException("Hubo un problema al eliminar la factura");
        }

        public List<DetalleFactura> ObtenerDetallesFacturas(DetalleFactura df)
        {
            return facturasRepositorio.ObtenerDetallesFacturas(df);
        }

        public Factura ObtenerFactura()
        {
            return facturasRepositorio.ObtenerFactura();
        }

        public Factura ObtenerFacturaBuscada(int nroFac)
        {
            return facturasRepositorio.ObtenerFacturaBuscada(nroFac);
        }
    }
}