using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class ClientesLookUp : Form
    {
        public Cliente cliente = null;

        
        public ClientesLookUp()
        {
            InitializeComponent();
            DoubleBuffered = true;
            
        }

        private void PoblarGrilla(DataGridView dgv, string cadenaBuscar)
        {
            dgvClientesLookUp.DataSource = ClienteServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar)
                ? cadenaBuscar
                : string.Empty);

            FormatearGrilla(dgvClientesLookUp);
        }

        private void FormatearGrilla(DataGridView dgv)
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
            dgv.Columns["ApyNom"].DisplayIndex = 0;

            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].Width = 100;
            dgv.Columns["Dni"].HeaderText = "DNI";
            dgv.Columns["Dni"].DisplayIndex = 0;
        }

        private void ClientesLookUp_Load(object sender, System.EventArgs e)
        {
            PoblarGrilla(dgvClientesLookUp, string.Empty);
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            cliente = null;
            this.Close();
        }

        private void btnBuscar_Click(object sender, System.EventArgs e)
        {
            PoblarGrilla(dgvClientesLookUp, txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void btnSeleccionar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void dgvClientesLookUp_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientesLookUp.Rows.Count > 0)
            {
                cliente = (Cliente)dgvClientesLookUp.Rows[e.RowIndex].DataBoundItem;

            }
            else
            {
                cliente = null;
            }
        }
    }
}
