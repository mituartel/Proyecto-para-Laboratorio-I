using System.Drawing;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;
using System.Runtime.InteropServices;

namespace X_Commerce
{
    public partial class Login : Form
    {
        private bool Salir;
        private bool Ingresar;

        private Empleado empleadoLogin;

        public bool puedeAccederAlSistema { get; private set; }

        public Empleado Empleado => empleadoLogin;

        
        public Login()
        {
            InitializeComponent();

            Salir = false;
            Ingresar = false;

        }




        private void linklblRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fNuevoEmpleado = new NuevoEmpleado();
            fNuevoEmpleado.ShowDialog();
            EmpleadoServicio.ObtenerEmpleadosDelArchivo();
        }





        private void btnAcceder_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Ingrese un usuario para continuar");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Ingrese una contraseña para continuar");
                return;
            }

            if (SeguridadServicio.VerificarSiExiste(txtUsuario.Text, txtPassword.Text))
            {
                empleadoLogin = EmpleadoServicio.ObtenerNombreUsuario(txtUsuario.Text);
                Ingresar = true;

                puedeAccederAlSistema = true;

                Close();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }


        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    }
}
