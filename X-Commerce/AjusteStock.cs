using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class AjusteStock : Form
    {
        public bool realizoOperacion; // Para poder mostrar en la grilla al momento de crearlo
        public long productoId; // Para poder utilizar el id del producto

        public AjusteStock(long id)
        {
            InitializeComponent();
            realizoOperacion = false;
            productoId = id;
        }

        private void iconPictureBoxCERRAR_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void iconButtonCANCEL_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            var stockNuevo = new Stock();

            stockNuevo.ProductoId = productoId;
            stockNuevo.Cantidad = nudStockAgregar.Value;
            stockNuevo.TipoMovimiento = TipoMovimiento.Ingreso;

            StockServicio.Agregar(stockNuevo);

            realizoOperacion = true;
            MessageBox.Show("Stock actualizado con exito");
            Close();
        }
    }
}
