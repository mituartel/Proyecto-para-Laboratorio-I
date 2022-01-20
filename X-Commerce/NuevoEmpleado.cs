using System;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class NuevoEmpleado : Form
    {
        public bool realizoOperacion;

        public NuevoEmpleado()
        {
            InitializeComponent();
            realizoOperacion = false;
        }
       
        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            // Validaciones de los campos de texto

            if (string.IsNullOrEmpty(txtLegajo.Text))
            {
                MessageBox.Show("Debe ingresar un Legajo");
                txtLegajo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un Apellido");
                txtApellido.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un Nombre");
                txtNombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar un Dni");
                txtDni.Focus();
                return;
            }

            if (string.IsNullOrEmpty(dtpFechaNacimiento.Text))
            {
                MessageBox.Show("Debe ingresar una Fecha de Nacimiento");
                dtpFechaNacimiento.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Debe ingresar una Calle");
                txtCalle.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Debe ingresar un Numero");
                txtNumero.Focus();
                return;
            }

            // No los valido porque hay gente que no tiene domicilios asi como en mi caso
            /*
            if (string.IsNullOrEmpty(txtPiso.Text))
            {
                MessageBox.Show("Debe ingresar un Piso");
                txtPiso.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDepartamento.Text))
            {
                MessageBox.Show("Debe ingresar un Departamento");
                txtDepartamento.Focus();
                return;
            }
            */

            var nuevoEmpleado = new Empleado();

            nuevoEmpleado.Legajo = int.Parse(txtLegajo.Text);
            nuevoEmpleado.Apellido = txtApellido.Text;
            nuevoEmpleado.Nombre = txtNombre.Text;
            nuevoEmpleado.Dni = txtDni.Text;
            nuevoEmpleado.FechaNacimiento = dtpFechaNacimiento.Value;
            nuevoEmpleado.Calle = txtCalle.Text;
            nuevoEmpleado.Numero = txtNumero.Text;
            nuevoEmpleado.Piso = txtPiso.Text;
            nuevoEmpleado.Departamento = txtDepartamento.Text;

            EmpleadoServicio.Agregar(nuevoEmpleado);

            realizoOperacion = true;

            MessageBox.Show("Empleado creado con exito");
            MessageBox.Show("Su contraseña por defecto es: 1234");
            Close();
        }

        private void NuevoEmpleado_Load(object sender, System.EventArgs e)
        {
            txtLegajo.Text = EmpleadoServicio.ObtenerSiguienteLegajo().ToString();
            dtpFechaNacimiento.Value = DateTime.Today; // Obtiene la fecha de la computadora
        }
    }
}
