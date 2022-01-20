using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using X_Commerce.Entidades;

namespace X_Commerce
{
    public partial class Principal : Form
    {
 
        private Empleado empleadoLogin;

        public Principal()
        {
            InitializeComponent();

     
            this.DoubleBuffered = true;
        }

        public Principal(Empleado empleado)
            : this()
        {
            this.empleadoLogin = empleado;
        }

     
        private void iconButtonSalirSISTEMA_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var venta = new Ventas(empleadoLogin);
            venta.ShowDialog();

            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {

            var cliente = new Clientes();
            cliente.ShowDialog();
        
        
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            var producto = new Productos();
            producto.ShowDialog();

           
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
          var empleado = new Empleados();
          empleado.ShowDialog(); 
            
        }

       
        private void Principal_Load(object sender, EventArgs e)
        {
            if (empleadoLogin != null)
            {
                lblUsuarioLogin.Text = empleadoLogin.ApyNom;
            }

        }

   
    }
}
