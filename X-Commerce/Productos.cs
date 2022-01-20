using System;
using System.Windows.Forms;
using X_Commerce.Entidades;
using X_Commerce.Servicios;

namespace X_Commerce
{
    public partial class Productos : Form
    {
        private Producto _productos; 

        public Productos()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            PoblarGrilla(dgvProductos, string.Empty);
        }

        public void PoblarGrilla(DataGridView dgv, string cadenaBuscar)
        {
            dgvProductos.DataSource = ProductoServicio.Obtener(!string.IsNullOrEmpty(cadenaBuscar)? cadenaBuscar : string.Empty);
            
            FormatearGrilla(dgvProductos);
        }

        public void FormatearGrilla(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].Visible = false;
            }

            dgv.Columns["Descripcion"].Visible = true;
            dgv.Columns["Descripcion"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Descripcion"].HeaderText = "Descripcion";
            dgv.Columns["Descripcion"].DisplayIndex = 0;

            dgv.Columns["Codigo"].Visible = true;
            dgv.Columns["Codigo"].HeaderText = "Código";
            dgv.Columns["Codigo"].Width = 100;
            dgv.Columns["Codigo"].DisplayIndex = 1;

            dgv.Columns["CodigoBarra"].Visible = true;
            dgv.Columns["CodigoBarra"].HeaderText = "Codigo de Barra";
            dgv.Columns["CodigoBarra"].Width = 100;
            dgv.Columns["CodigoBarra"].DisplayIndex = 2;


            dgv.Columns["Precio"].Visible = true;
            dgv.Columns["Precio"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Precio"].HeaderText = "Precio";
            dgv.Columns["Precio"].DisplayIndex = 3;

            dgv.Columns["StockInicial"].Visible = true;
            dgv.Columns["StockInicial"].HeaderText = "Stock Inicial";
            dgv.Columns["StockInicial"].Width = 100;
            dgv.Columns["StockInicial"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["StockInicial"].DisplayIndex = 4;

        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var fNuevoProducto = new NuevoProducto();
            fNuevoProducto.ShowDialog();

            if (fNuevoProducto.operacionRealizada) 
            {
                PoblarGrilla(dgvProductos, string.Empty);
            }
        }

        private void btnCargarStock_Click(object sender, EventArgs e)
        {
            var fNuevoStock = new AjusteStock(_productos.Id);
            fNuevoStock.ShowDialog();

            if (fNuevoStock.realizoOperacion)
            {
                FormatearGrilla(dgvProductos);
                var stock = StockServicio.ObtenerPorId(_productos.Id);
                nudStockActual.Value = StockServicio.CalcularStockActual(_productos.Id);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            PoblarGrilla(dgvProductos, txtBuscar.Text);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnBuscar.PerformClick();
            }
        }

        private void dgvProductos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {          
            if (dgvProductos.Rows.Count > 0)
            {
                _productos = (Producto)dgvProductos.Rows[e.RowIndex].DataBoundItem;
                var stock = StockServicio.CalcularStockActual(_productos.Id);

                nudStockActual.Value = stock;
            }
            else
            {
                _productos = null;
            }
        }

    }
}
