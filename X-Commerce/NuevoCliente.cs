using System;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class NuevoCliente : Form
    {
        public bool realizoOperacion;

        public NuevoCliente()
        {
            InitializeComponent();
            realizoOperacion = false;
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, System.EventArgs e)
        {
            // Validaciones de los campos de texto

            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe escribir un codigo");
                return;
            }

            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe escribir un Apellido");
                return;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe escribir un Nombre");
                return;
            }

            if (string.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Debe escribir un Dni");
                return;
            }

            if (string.IsNullOrEmpty(dtpFechaNacimiento.Text))
            {
                MessageBox.Show("Debe ingresar una fecha de nacimiento");
                return;
            }

            if (string.IsNullOrEmpty(txtCalle.Text))
            {
                MessageBox.Show("Debe escribir una calle");
                return;
            }

            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Debe escribir un numero");
                return;
            }

            if (string.IsNullOrEmpty(txtPiso.Text))
            {
                MessageBox.Show("Debe escribir un piso");
                return;
            }

            if (string.IsNullOrEmpty(txtDpto.Text))
            {
                MessageBox.Show("Debe escribir un departamento");
                return;
            }

            // RECORDATORIO VALIDAR EL GRUPO BOX DE LIMITE DE COMPRA


            // Ingresamos los datos al archivo clientes.txt

            var clienteNuevo = new Cliente();

            clienteNuevo.Codigo = int.Parse(txtCodigo.Text);
            clienteNuevo.Apellido = txtApellido.Text;
            clienteNuevo.Nombre = txtNombre.Text;
            clienteNuevo.Dni = txtDni.Text;
            clienteNuevo.FechaNacimiento = dtpFechaNacimiento.Value;
            clienteNuevo.Calle = txtCalle.Text;
            clienteNuevo.Numero = txtNumero.Text;
            clienteNuevo.Piso = txtPiso.Text;
            clienteNuevo.Departamento = txtDpto.Text;
            clienteNuevo.ActivarLimiteCompra = chkActivarLimiteCompra.Checked;
            clienteNuevo.MontoLimiteCompra = nudMontoMaximo.Value;

            ClienteServicio.Agregar(clienteNuevo);

            realizoOperacion = true;

            MessageBox.Show("Cliente agregado con exito");
            Close();

        }

        private void NuevoCliente_Load(object sender, System.EventArgs e)
        {
            txtCodigo.Text = ClienteServicio.ObtenerSiguienteCodigo().ToString();
            dtpFechaNacimiento.Value = DateTime.Today; // Obtiene la fecha de la computadora
        }

        private void iconPictureBoxCERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkActivarLimiteCompra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivarLimiteCompra.Checked == true)
            {
                nudMontoMaximo.Enabled = true;
                
            }
            else
            {
                nudMontoMaximo.Enabled = false;
            }

        }
    }
}
