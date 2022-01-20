using System.Windows.Forms;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class Empleados : Form
    {     
        public Empleados()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }
 
        private void Empleados_Load(object sender, System.EventArgs e)
        {
            PoblarGrilla(dgvEmpleados, string.Empty);         
        }

        public void PoblarGrilla(DataGridView dgv ,string cadenaBuscar)
        {       
            dgvEmpleados.DataSource = EmpleadoServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar)
                ? cadenaBuscar
                : string.Empty);
            FormatearGrilla(dgvEmpleados);
        }
        
        public void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;            
            }
            dgv.Columns["ApyNom"].Visible = true;
            dgv.Columns["ApyNom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ApyNom"].HeaderText = "Apellido y Nombre";
            dgv.Columns["ApyNom"].DisplayIndex = 0;


            dgv.Columns["Dni"].Visible = true;
            dgv.Columns["Dni"].Width = 100;
            dgv.Columns["Dni"].HeaderText = "DNI";
            dgv.Columns["Dni"].DisplayIndex = 1;

            dgv.Columns["FechaNacimientoStr"].Visible = true;
            dgv.Columns["FechaNacimientoStr"].HeaderText = "Fecha Nacimiento";
            dgv.Columns["FechaNacimientoStr"].Width = 150;
            dgv.Columns["FechaNacimientoStr"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["FechaNacimientoStr"].DisplayIndex = 2;
            
            dgv.Columns["DireccionCompleta"].Visible = true;
            dgv.Columns["DireccionCompleta"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["DireccionCompleta"].HeaderText = "Domicilio";
            dgv.Columns["DireccionCompleta"].DisplayIndex = 3;

            dgv.Columns["Legajo"].Visible = true;
            dgv.Columns["Legajo"].HeaderText = "Legajo";
            dgv.Columns["Legajo"].Width = 100;
            dgv.Columns["Legajo"].DisplayIndex = 4;

        }

        private void btnNuevoEmpleado_Click(object sender, System.EventArgs e)
        {
            var fNuevoEmpleado = new NuevoEmpleado();
            fNuevoEmpleado.ShowDialog();

            if (fNuevoEmpleado.realizoOperacion)
            {
                PoblarGrilla(dgvEmpleados, string.Empty);
            }
        }

        private void btnBusqueda_Click(object sender, System.EventArgs e)
        {
            PoblarGrilla(dgvEmpleados, txtBusqueda.Text);
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBusqueda.PerformClick();
            }
        }
    }
}
