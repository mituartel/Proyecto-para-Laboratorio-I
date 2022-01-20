using System;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class Clientes : Form
    {
        private Cliente _clientes; // Para poder mostrar el saldo actual

        public Clientes()
        {
            InitializeComponent();

            
            DoubleBuffered = true;

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            
            PoblarGrilla(dgvClientes, string.Empty);
        }

        public void PoblarGrilla(DataGridView dgv ,string cadenaBuscar)
        {
            dgvClientes.DataSource = ClienteServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar)
                ? cadenaBuscar
                : string.Empty);

            FormatearGrilla(dgvClientes);
        }

        public void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.Columns["Codigo"].Visible = true;
            dgv.Columns["Codigo"].HeaderText = "Código";
            dgv.Columns["Codigo"].Width = 100;
            dgv.Columns["Codigo"].DisplayIndex = 0;

            dgv.Columns["ApyNom"].Visible = true;
            dgv.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNom"].DisplayIndex = 1;

            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].Width = 100;
            dgv.Columns["Dni"].HeaderText = "DNI";
            dgv.Columns["Dni"].DisplayIndex = 2;

            dgv.Columns["FechaNacimientoStr"].Visible = true;
            dgv.Columns["FechaNacimientoStr"].HeaderText = "Fecha Nacimiento";
            dgv.Columns["FechaNacimientoStr"].Width = 150;
            dgv.Columns["FechaNacimientoStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["FechaNacimientoStr"].DisplayIndex = 3;

            dgv.Columns["DireccionCompleta"].Visible = true;
            dgv.Columns["DireccionCompleta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["DireccionCompleta"].HeaderText = "Domicilio";
            dgv.Columns["DireccionCompleta"].DisplayIndex = 4;

           
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var fNuevoCliente = new NuevoCliente();
            fNuevoCliente.ShowDialog();

            if (fNuevoCliente.realizoOperacion) // para q se actualize en la grillaLookUp al momento de crearlo
            {
                PoblarGrilla(dgvClientes, string.Empty);
            }
        }

        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            var fCuentaCorriente = new CuentaCorrientes(_clientes);
            fCuentaCorriente.ShowDialog();
     
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PoblarGrilla(dgvClientes, txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void dgvClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows.Count > 0)
            {
                _clientes = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;
                
            }
            else
            {
                _clientes = null;
            }
        }
    }
}
