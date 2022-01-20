using System;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class PagoCtaCte : Form
    {
        public bool realizoOperacion;

        private Cliente _cliente;

        private decimal _saldoPendiente;

        public PagoCtaCte(Cliente cliente, decimal saldoPendiente)
        {
            InitializeComponent();
            realizoOperacion = false;

            _cliente = cliente;
            _saldoPendiente = saldoPendiente;
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (nudMonto.Value == 0)
            {
                MessageBox.Show("Debe escribir un monto mayor a 0");
                return;
            }

            if ((nudMonto.Value + _saldoPendiente) > _cliente.MontoLimiteCompra)
            {
                MessageBox.Show("El Saldo Pendiente no puede superar el limite del Monto");
                return;
            }

            var ctacte = new CuentaCorriente();

            ctacte.ClienteId = _cliente.Id;
            ctacte.Fecha = DateTime.Now;
            ctacte.Descripcion = "Pago de Cuenta Corriente";
            ctacte.Monto = nudMonto.Value;
            ctacte.TipoMovimiento = TipoMovimiento.Ingreso;

            CuentaCorrienteServicio.Agregar(ctacte);

            realizoOperacion = true;
            MessageBox.Show("Pago Cuenta Corriente con exito");
            Close();


        }

        
    }
}
