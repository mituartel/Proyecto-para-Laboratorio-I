using System;
using System.Windows.Forms;
using X_Commerce.Servicios;

namespace X_Commerce
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Esto es para que cargue los datos del Cliente,Producto,Empleado,etc al arrancar el programa
            SeguridadServicio.ObtenerDatosDelArchivo();
            EmpleadoServicio.ObtenerEmpleadosDelArchivo();
            ClienteServicio.ObtenerClientesDelArchivo();
            ProductoServicio.ObtenerProductosDelArchivo();
            StockServicio.ObtenerStocksDelArchivo();
            CuentaCorrienteServicio.ObtenerCtaCteDelArchivo();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var fLogin = new Login();
            fLogin.ShowDialog();

            if (fLogin.puedeAccederAlSistema)
            {
                Application.Run(new Principal(fLogin.Empleado));
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
