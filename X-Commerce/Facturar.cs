using System;
using System.Collections.Generic;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class Facturar : Form
    {
        public bool seFacturo;

        private List<DetalleFactura> _detalleFactura = new List<DetalleFactura>();

        private Factura _factura = new Factura();

        private Cliente _cliente;

        public Facturar(List<DetalleFactura> detalleFacturas, Factura factura, Cliente cliente)
        {
            InitializeComponent();

            _detalleFactura = detalleFacturas;
            _factura = factura;
            _cliente = cliente;
        }

        private void Facturar_Load(object sender, EventArgs e)
        {

            nudTotalPagar.Value = _factura.Total;
            cmbFormaPago.SelectedIndex = 0;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            seFacturo = false;
            this.Close();
        }

        private void cmbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text == "Cuenta Corriente")
            {
                nudPagarCon.Enabled = false;
               

                nudPagarCon.Value = 0;
                txtVuelto.Text = "0";
            }
            else
            {
                nudPagarCon.Enabled = true;
               
            }
        }

        private void nudPagarCon_ValueChanged(object sender, EventArgs e)
        {
            if (nudTotalPagar.Value < nudPagarCon.Value)
            {
                txtVuelto.Text = (nudPagarCon.Value - nudTotalPagar.Value).ToString();
            }
            else
            {
                txtVuelto.Text = "0";
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (cmbFormaPago.Text == "Efectivo")
            {
                if (nudTotalPagar.Value > nudPagarCon.Value)
                {
                    MessageBox.Show("El monto ingresado no es suficiente para realizar el pago");
                    return;
                }
                else
                {
                    FacturaServicio.AgregarFactura(_factura);

                    foreach (var mov in _detalleFactura)
                    {
                        FacturaServicio.AgregarDetalleFactura(mov);
                    }

                    MessageBox.Show("Factura realizada con exito");

                    seFacturo = true;
                    Close();
                }
            }
            else
            {
                if (!_cliente.ActivarLimiteCompra)
                {
                    MessageBox.Show("Este cliente no tiene habilitada una Cuenta Corriente");

                }
                else if (!calcularSaldo())
                {
                    MessageBox.Show("Saldo de Cuenta Corriente insuficiente");

                }
                else
                {
                    CuentaCorriente cuentaCorrienteNueva = new CuentaCorriente();

                    cuentaCorrienteNueva.ClienteId = _factura.ClienteId;
                    cuentaCorrienteNueva.Descripcion = "Compra";
                    cuentaCorrienteNueva.Fecha = _factura.Fecha;
                    cuentaCorrienteNueva.Monto = _factura.Total;
                    cuentaCorrienteNueva.TipoMovimiento = TipoMovimiento.Egreso;

                    CuentaCorrienteServicio.Agregar(cuentaCorrienteNueva);
                    FacturaServicio.AgregarFactura(_factura);

                    foreach (var mov in _detalleFactura)
                    {
                        FacturaServicio.AgregarDetalleFactura(mov);
                    }

                    MessageBox.Show("Factura realizada con exito");

                    seFacturo = true;
                    Close();
                }
                             
            }

        }

        public bool calcularSaldo()
        {
            List<CuentaCorriente> cuentaCorrientes = new List<CuentaCorriente>();
            cuentaCorrientes = CuentaCorrienteServicio.Obtener(_cliente.Id.ToString());

            decimal restar = 0;

            foreach (var mov in cuentaCorrientes)
            {
                if (mov.TipoMovimiento == TipoMovimiento.Egreso)
                {
                    restar += mov.Monto * 1;
                }
                else
                {
                    restar += mov.Monto * -1;
                }
            }

            decimal saldo = _cliente.MontoLimiteCompra - restar;

            if (saldo < _factura.Total)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
