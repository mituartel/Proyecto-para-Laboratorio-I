using X_Commerce.Servicios;

namespace X_Commerce.Entidades
{
    public class Producto
    {
        public long Id { get; set; }

        public int Codigo { get; set; }

        public string CodigoBarra { get; set; }

        public string Descripcion { get; set; }

        public decimal Precio { get; set; }
 
        public decimal StockInicial { get; set; }

    }
}
