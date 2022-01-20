using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class NuevoProducto : Form
    {
        public bool operacionRealizada;




        public NuevoProducto()
        {
            InitializeComponent();
            operacionRealizada = false;
        }

        private void NuevoProducto_Load(object sender, System.EventArgs e)
        {
            txtCodigo.Text = ProductoServicio.ObtenerSiguienteCodigo().ToString();
        }

        private void btnVolver_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
      
            if (string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                MessageBox.Show("Ingrese codigo de barra");
                return;
            }

            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese descripcion");
                return;
            }

            if (nudPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0");
                return;
            }

            if (nudStockInicial.Value <= 0)
            {
                MessageBox.Show("El stock inicial debe ser mayor a 0");
                return;
            }

    
            var productoNuevo = new Producto();
            productoNuevo.Descripcion = txtDescripcion.Text;
            productoNuevo.Codigo = int.Parse(txtCodigo.Text);
            productoNuevo.CodigoBarra = txtCodigoBarra.Text;
            productoNuevo.Precio = nudPrecio.Value;
            productoNuevo.StockInicial = nudStockInicial.Value;

            ProductoServicio.Agregar(productoNuevo);

            productoNuevo.Id = ProductoServicio.ObtenerId(txtCodigo.Text);


            var stockNuevo = new Stock();
            stockNuevo.ProductoId = productoNuevo.Id;
            stockNuevo.Cantidad = nudStockInicial.Value;
            stockNuevo.TipoMovimiento = TipoMovimiento.Ingreso;

            StockServicio.Agregar(stockNuevo);
            operacionRealizada = true;

            MessageBox.Show("Producto agregado correctamente");
            Close();
        }



        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
