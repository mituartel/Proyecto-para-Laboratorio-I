using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class ProductoServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}/Productos.txt";

        public static List<Producto> Productos = new List<Producto>();

        public static void ObtenerProductosDelArchivo()
        {
            string[] productos = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in productos)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                var nuevoProducto = new Producto();

                nuevoProducto.Id = long.Parse(linea.Substring(PlantillaProducto.IdDesde, PlantillaProducto.IdCantidad));
                nuevoProducto.Codigo = int.Parse(linea.Substring(PlantillaProducto.CodigoDesde, PlantillaProducto.CodigoCantidad));
                nuevoProducto.CodigoBarra = linea.Substring(PlantillaProducto.CodigoBarraDesde, PlantillaProducto.CodigoBarraCantidad).Trim();
                nuevoProducto.Descripcion = linea.Substring(PlantillaProducto.DescripcionDesde, PlantillaProducto.DescripcionCantidad).Trim();
                nuevoProducto.Precio = decimal.Parse(linea.Substring(PlantillaProducto.PrecioDesde, PlantillaProducto.PrecioCantidad));
                nuevoProducto.StockInicial = decimal.Parse(linea.Substring(PlantillaProducto.StockInicialDesde, PlantillaProducto.StockInicialCantidad));

                Productos.Add(nuevoProducto);
            }
        }

        public static void Agregar(Producto nuevoProducto)
        {
            // Obtiene un Identificador Unico para el nuevo Producto
            nuevoProducto.Id = Productos.Any()
                ? Productos.Max(x => x.Id) + 1
                : 1;

            // Se agrega al Archivo
            var archivoProducto = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevoProducto.Id.ToString().PadRight(PlantillaProducto.IdCantidad, ' ')}"
                             + $"{nuevoProducto.Codigo.ToString().PadRight(PlantillaProducto.CodigoCantidad, ' ')}"
                             + $"{nuevoProducto.CodigoBarra.PadRight(PlantillaProducto.CodigoBarraCantidad, ' ')}"
                             + $"{nuevoProducto.Descripcion.PadRight(PlantillaProducto.DescripcionCantidad, ' ')}"
                             + $"{nuevoProducto.Precio.ToString().PadRight(PlantillaProducto.PrecioCantidad, ' ')}"
                             + $"{nuevoProducto.StockInicial.ToString().PadRight(PlantillaProducto.StockInicialCantidad, ' ')}";

            archivoProducto.WriteLine(crearLinea);
            archivoProducto.Close();

            // Se agrega a la Lista Estatica
            Productos.Add(nuevoProducto);
        }

        public static List<Producto> Obtener(string cadenaBuscar)
        {
            return Productos.Where(x => x.Codigo.ToString().Contains(cadenaBuscar)
                                        || x.StockInicial.ToString().Contains(cadenaBuscar))
                .ToList();
        }
        
        public static long ObtenerId(string codigo)
        {
            var producto = Productos.Where(x => x.Codigo.ToString().Contains(codigo)).FirstOrDefault();
            return producto.Id;
        }

        public static Producto ObtenerPorCodigo(string codigo)
        {
            var producto = Productos.Where(x => x.Codigo.ToString().Contains(codigo)).FirstOrDefault();
            return producto;

        }

        public static int ObtenerSiguienteCodigo()
        {
            return Productos.Any() // Pregunto si tiene algun registro cargado
                ? Productos.Max(x => x.Codigo) + 1 // Obtengo el valor maximo del legajo + 1
                : 1;
        }
    }
}
