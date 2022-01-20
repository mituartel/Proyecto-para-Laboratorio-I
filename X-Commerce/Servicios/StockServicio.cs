using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class StockServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}/Stocks.txt";

        public static List<Stock> Stocks = new List<Stock>();

        public static void ObtenerStocksDelArchivo()
        {
            string[] stocks = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in stocks)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                var nuevoStock = new Stock();

                nuevoStock.ProductoId = long.Parse(linea.Substring(PlantillaStock.ProductoIdDesde, PlantillaStock.ProductoIdCantidad));
                nuevoStock.Cantidad = decimal.Parse(linea.Substring(PlantillaStock.CantidadDesde, PlantillaStock.CantidadCantidad));
                nuevoStock.TipoMovimiento = linea.Substring(PlantillaStock.TipoMovimientoDesde, PlantillaStock.TipoMovimientoCantidad) == "-1"
                    ? TipoMovimiento.Egreso
                    : TipoMovimiento.Ingreso;

                Stocks.Add(nuevoStock);
            }
        }

        public static void Agregar(Stock nuevoStock)
        {          
            // Se agrega al Archivo
            var archivoStock = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevoStock.ProductoId.ToString().PadRight(PlantillaStock.ProductoIdCantidad, ' ')}"
                             + $"{nuevoStock.Cantidad.ToString().PadRight(PlantillaStock.CantidadCantidad, ' ')}"                         
                             + $"{nuevoStock.TipoMovimiento.ToString().PadRight(PlantillaStock.TipoMovimientoCantidad, ' ')}";

            archivoStock.WriteLine(crearLinea);
            archivoStock.Close();

            // Se agrega a la Lista Estatica
            Stocks.Add(nuevoStock);       
        }

        public static Stock ObtenerPorId(long productoId)
        {
            return Stocks.Where(x => x.ProductoId == productoId).LastOrDefault();
        }
    
        public static decimal CalcularStockActual(long productoId)
        {
            var movProductos = Stocks.Where(x => x.ProductoId == productoId);
            decimal stockActual = 0;

            foreach (var mov in movProductos)
            {
                stockActual += mov.Cantidad * (int)mov.TipoMovimiento;
            }

            return stockActual;

        }
    }
}
