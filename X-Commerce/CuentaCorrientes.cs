using System.Collections.Generic;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class CuentaCorrientes : Form
    {
        private List<CuentaCorriente> _ctaCte = new List<CuentaCorriente>(); //Para poder mostrar el saldo actual

        private Cliente _cliente;

        public CuentaCorrientes(Cliente cliente)
        {
            InitializeComponent();
            DoubleBuffered = true;
            _cliente = cliente;
        }

        private void CuentaCorriente_Load(object sender, System.EventArgs e)
        {
            calcularSaldo();
            PoblarGrilla(dgvCuentaCorriente, _cliente.Id.ToString());         
        }

        public void PoblarGrilla(DataGridView dgv, string cadenaBuscar)
        {

            dgvCuentaCorriente.DataSource = CuentaCorrienteServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar)
                ? cadenaBuscar
                : string.Empty);

            FormatearGrilla(dgvCuentaCorriente);
        }

        private void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = "Descripcion";
            dgv.Columns["Descripcion"].DisplayIndex = 0;

            dgv.Columns["Fecha"].Visible = true;
            dgv.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Fecha"].HeaderText = "Fecha";
            dgv.Columns["Fecha"].DisplayIndex = 1;

            dgv.Columns["Monto"].Visible = true;
            dgv.Columns["Monto"].Width = 100;
            dgv.Columns["Monto"].HeaderText = "Monto";
            dgv.Columns["Monto"].DisplayIndex = 2;          
        }

        private void btnNuevoPago_Click(object sender, System.EventArgs e)
        {
            var fPagoCtaCte = new PagoCtaCte(_cliente, decimal.Parse(txtSaldoPendiente.Text));
            fPagoCtaCte.ShowDialog();

            if (fPagoCtaCte.realizoOperacion)
            {
                PoblarGrilla(dgvCuentaCorriente, _cliente.Id.ToString());
                calcularSaldo();
            }
        }

        private void iconButtonSALIENDO_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public void calcularSaldo()
        {
            _ctaCte = CuentaCorrienteServicio.Obtener(_cliente.Id.ToString());
            decimal restar = 0;

            foreach (var mov in _ctaCte)
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

            decimal resultado = _cliente.MontoLimiteCompra - restar;
            txtSaldoPendiente.Text = resultado.ToString();
        }
    }
}
