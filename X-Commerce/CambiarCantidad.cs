using System;
using System.Windows.Forms;
using X_Commerce.Entidades;

namespace X_Commerce
{
    public partial class CambiarCantidad : Form
    {
        private decimal _cantidad;
        public decimal cant;
        public int cod;

        public CambiarCantidad(decimal cantidad, int codigoProducto)
        {
            InitializeComponent();

            _cantidad = cantidad;
            cod = codigoProducto;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            _cantidad = 0;
            this.Close();
        }

        private void CambiarCantidad_Load(object sender, EventArgs e)
        {
            nudCantidad.Value = _cantidad;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad a eligir debe ser mayor a 0");
                cant = 0;
            }
            else
            {
                MessageBox.Show("La cantidad fue cambiada");
                
                int n = (int)nudCantidad.Value;
                cant = n;
                Close();
            }

            
        }
    }
}
