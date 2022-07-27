using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PAV1_GYM.Entidades;
using PAV1_GYM.Servicios;

namespace PAV1_GYM.InterfacesDeUsuarios
{
    public partial class Facturar : Form
    {
        private Socio socio;
        private Factura factura;
        private Empleado empleadoLogueado;
        private TiposDocumentoServicio tiposDocumentoServicio;
        private ActividadesServicio actividadesServicio;
        private PlanesServicio planesServicio;
        private MetodosPagoServicio metodosPagoServicio;
        private EmpleadosServicio empleadosServicio;
        private SociosServicio sociosServicio;
        private FacturasServicio facturasServicio;
        private MetodoPago mp;
        private float precioPlan = 0;
        private float precioActividad = 0;
        private float precioTotal = 0;
        private int contador;
        private float descuento;
        private float subTotal;
        private float descResumen;
        private float totalFacturado;
        private bool seCargoFactura = false;
        private Dictionary<int, DetalleFactura> DicDetalleFac = new Dictionary<int, DetalleFactura>();

        public Facturar()
        {
            socio = new Socio();
            factura = new Factura();
            tiposDocumentoServicio = new TiposDocumentoServicio();
            actividadesServicio = new ActividadesServicio();
            planesServicio = new PlanesServicio();
            metodosPagoServicio = new MetodosPagoServicio();
            empleadosServicio = new EmpleadosServicio();
            sociosServicio = new SociosServicio();
            facturasServicio = new FacturasServicio();
            InitializeComponent();
        }

        #region CargarDatos
        private void Facturar_Load(object sender, EventArgs e)
        {
            LblFechaActual.Text = $"Fecha Actual: {DateTime.Today.ToShortDateString()}";
            empleadoLogueado = EmpleadosServicio.UsuarioLogueado;
            string nombreEmpleado = $"{empleadoLogueado?.Nombre}";
            if (empleadoLogueado.LegajoEmpleado != 1)
            {
                empleadoLogueado = empleadosServicio.ObtenerEmpleadoLeg(empleadoLogueado.LegajoEmpleado);
                nombreEmpleado = $"{empleadoLogueado?.Nombre}, {empleadoLogueado?.Apellido}";
            }
            TxtLegajoEmpleado.Text = empleadoLogueado.LegajoEmpleado.ToString();
            TxtNombreEmpleado.Text = nombreEmpleado;
            CargarTiposDocumento();
            CargarActividades();
            CargarPlanes();
            CargarMetodosPago();
            BtnEliminarUno.Enabled = false;
            BtnEliminarTodos.Enabled = false;
        }
        private void CargarTiposDocumento()
        {
            var tiposDocumento = tiposDocumentoServicio.GetTiposDocumento();
            var tipoSeleccionado = tiposDocumento.First();
            var conector = new BindingSource();
            conector.DataSource = tiposDocumento;
            CbTipoDocumento.DataSource = conector;
            CbTipoDocumento.DisplayMember = "Nombre";
            CbTipoDocumento.ValueMember = "Id_TipoDoc";
            CbTipoDocumento.SelectedItem = tipoSeleccionado;
        }
        private void CargarActividades()
        {
            var actividades = actividadesServicio.GetActividades();
            var actividadDefault = new Actividad();
            actividadDefault.Nombre = "Seleccionar";
            actividades.Add(actividadDefault);
            var conector = new BindingSource();
            conector.DataSource = actividades;
            CbActividad.DataSource = conector;
            CbActividad.DisplayMember = "Nombre";
            CbActividad.ValueMember = "Id_Actividad";
            CbActividad.SelectedItem = actividadDefault;
        }
        private void CargarPlanes()
        {
            var planes = planesServicio.GetPlanes();
            var planDefault = new Plan();
            planDefault.Nombre = "Seleccionar";
            planes.Add(planDefault);
            var conector = new BindingSource();
            conector.DataSource = planes;
            CbPlan.DataSource = conector;
            CbPlan.DisplayMember = "Nombre";
            CbPlan.ValueMember = "Id_Plan";
            CbPlan.SelectedItem = planDefault;
        }
        private void CargarMetodosPago()
        {
            var metodosPago = metodosPagoServicio.GetMetodosPago();
            var metodoPagoDefault = new MetodoPago();
            metodoPagoDefault.Nombre = "Seleccionar";
            metodosPago.Add(metodoPagoDefault);
            var conector = new BindingSource();
            conector.DataSource = metodosPago;
            CbMetodoPago.DataSource = conector;
            CbMetodoPago.DisplayMember = "Nombre";
            CbMetodoPago.ValueMember = "Id_MetodoPago";
            CbMetodoPago.SelectedItem = metodoPagoDefault;
        }
        public void CargarSocio(Socio socio)
        {
            TxtNombre.Text = socio.Nombre;
            TxtApellido.Text = socio.Apellido;
            TxtNroDocumento.Text = socio.NroDocumento;
            CbTipoDocumento.SelectedValue = socio.TipoDocumento.Id_TipoDoc;
            TxtCodigoPostal.Text = socio.CodigoPostal;
            TxtCalle.Text = socio.Calle;
            TxtNroCalle.Text = socio.NroCalle.ToString();
            TxtTelefono.Text = socio.Telefono;
        }
        public void CargarFactura(Factura f)
        {
            TxtNombre.Text = f.Socio.Nombre;
            TxtApellido.Text = f.Socio.Apellido;
            TxtNroDocumento.Text = f.Socio.NroDocumento;
            CbTipoDocumento.SelectedIndex = f.Socio.TipoDocumento.Id_TipoDoc;
            TxtCodigoPostal.Text = f.Socio.CodigoPostal;
            TxtCalle.Text = f.Socio.Calle;
            TxtNroCalle.Text = f.Socio.NroCalle.ToString();
            TxtTelefono.Text = f.Socio.Telefono;
            TxtNroDocumento.Enabled = false;
            CbTipoDocumento.Enabled = false;
            string nombreEmpleado = $"{f.Empleado.Nombre}";
            if (f.Empleado.LegajoEmpleado != 1)
            {
                nombreEmpleado += $", {f.Empleado.Apellido}";
            }
            TxtLegajoEmpleado.Text = f.Empleado.LegajoEmpleado.ToString();
            TxtNombreEmpleado.Text = nombreEmpleado;
            var dff = new DetalleFactura();
            var fac = new Factura();
            fac.NroFactura = f.NroFactura;
            dff.Factura = fac;
            var detallesFacturas = facturasServicio.ObtenerDetallesFacturas(dff);
            foreach (DetalleFactura df in detallesFacturas)
            {
                CargarDetalleFac(df);
            }
            seCargoFactura = true;
            HabilitarBotones(false);
        }
        #endregion

        #region Clicks

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvDetalleFactura.RowCount > 0)
                {
                    if (!EsFacturaValida())
                        return;
                    if (facturasServicio.RegistrarFactura(factura, DicDetalleFac))
                    {
                        MessageBox.Show("Factura cargada con éxito", "Información");
                        seCargoFactura = true;
                        HabilitarBotones(false);
                    }
                    else
                        MessageBox.Show("Error, no se pudo cargar la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("No hay datos que cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkBuscarFactura_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                int nroFactura;
                if (!(int.TryParse(TxtNroFactura.Text, out nroFactura)) || nroFactura <= 0)
                {
                    TxtNroFactura.Text = "";
                    MessageBox.Show("Ingrese un número número de factura válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtNroFactura.Focus();
                }
                else
                {
                    var facturaBuscada = new Factura();
                    facturaBuscada = facturasServicio.ObtenerFacturaBuscada(nroFactura);
                    if (facturaBuscada == null)
                    {
                        TxtNroFactura.Text = "";
                        MessageBox.Show("La factura no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNroFactura.Focus();
                    }
                    else
                    {
                        LimpiarCampos();
                        factura = facturaBuscada;
                        CargarFactura(facturaBuscada);
                    }
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LnkBuscarSocio_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var nroDoc = TxtNroDocumento.Text;
                int tipoDoc = ((TipoDocumento)CbTipoDocumento.SelectedItem).Id_TipoDoc;
                if (nroDoc.Length > 0)
                {
                    var socioBuscado = new Socio();
                    socioBuscado = sociosServicio.ObtenerSocio(nroDoc, tipoDoc);
                    if (socioBuscado == null)
                    {
                        MessageBox.Show("El socio no existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TxtNroDocumento.Focus();
                    }
                    else
                    {
                        socio = socioBuscado;
                        CargarSocio(socioBuscado);
                        TxtNroDocumento.Enabled = false;
                        CbTipoDocumento.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un documento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtNroDocumento.Focus();
                }
            }
            catch (ApplicationException aex)
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!EsCamposValidos())
                return;
            var actividad = (Actividad)CbActividad.SelectedItem;
            var plan = (Plan)CbPlan.SelectedItem;
            bool existe = false;
            foreach (DetalleFactura df in DicDetalleFac.Values)
            {
                if (df.Actividad.Id_Actividad == actividad.Id_Actividad)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                BtnEliminarTodos.Enabled = true;
                var df = new DetalleFactura()
                {
                    Actividad = actividad,
                    Plan = plan,
                    PrecioUnitario = actividad.Precio + plan.PrecioEstandar,
                    Promocion = descuento,
                    FechaDevPrevista = DateTime.Today,
                    FechaDevReal = DateTime.Today
                };
                CargarDetalleFac(df);
            }
            else
                MessageBox.Show("Producto ya cargado!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            LimpiarProductos();
        }

        private void BtnEliminarUno_Click(object sender, EventArgs e)
        {
            if (DgvDetalleFactura.RowCount == 0)
            {
                LimpiarResumen();
            }
            else
            {
                descResumen -= Convert.ToInt32(DgvDetalleFactura.SelectedRows[0].Cells[4].Value);
                subTotal -= Convert.ToInt32(DgvDetalleFactura.SelectedRows[0].Cells[2].Value);
                totalFacturado -= Convert.ToInt32(DgvDetalleFactura.SelectedRows[0].Cells[5].Value);
                TxtSubTotal.Text = subTotal.ToString();
                TxtDescuentoResumen.Text = descResumen.ToString();
                TxtTotalFacturado.Text = totalFacturado.ToString();
                DicDetalleFac.Remove(Convert.ToInt32(DgvDetalleFactura.SelectedRows[0].Cells[0].Value));
                DgvDetalleFactura.Rows.Remove(DgvDetalleFactura.CurrentRow);
            }
        }

        private void BtnEliminarTodos_Click(object sender, EventArgs e)
        {
            LimpiarResumen();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Funciones

        private bool EsCamposValidos()
        {
            if (TxtNombre.Text.Equals(""))
            {
                MessageBox.Show("Cargue a un socio primero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (((Actividad)CbActividad.SelectedItem).Nombre == "Seleccionar" || ((Plan)CbPlan.SelectedItem).Nombre == "Seleccionar")
            {
                MessageBox.Show("Ingrese una actividad y un plan válidos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (((MetodoPago)CbMetodoPago.SelectedItem).Nombre == "Seleccionar")
            {
                MessageBox.Show("Ingrese un método de pago válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }

        private bool EsFacturaValida()
        {
            var facturaIngresada = new Factura
            {
                Socio = socio,
                Empleado = empleadoLogueado,
                MetodoPago = mp,
                Fecha = DateTime.Now,
                MontoTotal = totalFacturado,
                CondicionCobro = true
            };
            factura = facturaIngresada;
            return true;
        }

        private void LimpiarCampos()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtNroDocumento.Text = "";
            CbTipoDocumento.SelectedIndex = 0;
            TxtCodigoPostal.Text = "";
            TxtCalle.Text = "";
            TxtNroCalle.Text = "";
            TxtTelefono.Text = "";
            TxtNroDocumento.Enabled = true;
            CbTipoDocumento.Enabled = true;

            TxtSubTotal.Text = "";
            TxtDescuentoResumen.Text = "";
            TxtTotalFacturado.Text = "";

            TxtNroFactura.Text = "";

            HabilitarBotones(true);
            LimpiarProductos();
            LimpiarResumen();
        }

        private void LimpiarProductos()
        {
            CbActividad.SelectedIndex = CbActividad.Items.Count - 1;
            CbPlan.SelectedIndex = CbPlan.Items.Count - 1;
            CbMetodoPago.SelectedIndex = CbMetodoPago.Items.Count - 1;
            TxtPrecio.Text = "";
            TxtDescuento.Text = "";
        }

        private void LimpiarResumen()
        {
            precioPlan = 0;
            precioActividad = 0;
            precioTotal = 0;
            contador = 0;
            descuento = 0;
            subTotal = 0;
            descResumen = 0;
            totalFacturado = 0;
            TxtSubTotal.Text = "";
            TxtDescuentoResumen.Text = "";
            TxtTotalFacturado.Text = "";
            DicDetalleFac.Clear();
            DgvDetalleFactura.Rows.Clear();
            seCargoFactura = false;
            BtnEliminarUno.Enabled = false;
            BtnEliminarTodos.Enabled = false;
        }

        private void HabilitarBotones(bool op)
        {
            BtnEliminarTodos.Enabled = op;
            CbActividad.Enabled = op;
            CbPlan.Enabled = op;
            CbMetodoPago.Enabled = op;
            BtnIngresar.Enabled = op;
            LnkBuscarSocio.Enabled = op;
            BtnCargar.Enabled = op;
        }

        private void DgvDetalleFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!seCargoFactura)
                BtnEliminarUno.Enabled = true;
        }

        private void CbPlan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var plan = (Plan)CbPlan.SelectedItem;
            precioTotal -= precioPlan;
            precioPlan = plan.PrecioEstandar;
            precioTotal += precioPlan;
            TxtPrecio.Text = precioTotal.ToString();
        }

        private void CbActividad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var actividad = (Actividad)CbActividad.SelectedItem;
            precioTotal -= precioActividad;
            precioActividad = actividad.Precio;
            precioTotal += precioActividad;
            TxtPrecio.Text = precioTotal.ToString();
        }

        private void CbMetodoPago_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var metodoPago = (MetodoPago)CbMetodoPago.SelectedItem;
            if (metodoPago.Nombre == "Efectivo")
                descuento = 500;
            else if (metodoPago.Nombre == "Transferencia")
                descuento = 300;
            else
                descuento = 0;
            TxtDescuento.Text = descuento.ToString();
            mp = metodoPago;
        }

        private void CargarDetalleFac(DetalleFactura df)
        {
            contador += 1;
            df.Orden = contador;
            DicDetalleFac.Add(contador, df);

            subTotal += df.PrecioUnitario;
            descResumen += df.Promocion;
            totalFacturado += df.PrecioUnitario - df.Promocion;
            TxtSubTotal.Text = subTotal.ToString();
            TxtDescuentoResumen.Text = descResumen.ToString();
            TxtTotalFacturado.Text = totalFacturado.ToString();

            var fila = new string[] {
            $"{contador}",
            $"{df.Actividad.Nombre}, {df.Plan.Nombre}",
            $"{df.PrecioUnitario}",
            "1",
            $"{df.Promocion}",
            $"{df.PrecioUnitario - df.Promocion}",
            };
            DgvDetalleFactura.Rows.Add(fila);
        }
        #endregion
    }
}