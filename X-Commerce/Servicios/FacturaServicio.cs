using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Dto;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class FacturaServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}/Facturas.txt";
        private static string detalleDelArchivo = $@"{Environment.CurrentDirectory}/DetalleFacturas.txt";

        public static List<Factura> Facturas = new List<Factura>();
        public static List<DetalleFactura> DetalleFacturas = new List<DetalleFactura>();

        // 1 Solo Obtener datos que accede a los Archivos
        public static void ObtenerDatosDelArchivo()
        {
            // Facturas
            string[] facturas = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in facturas)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                var nuevoFactura = new Factura();

                nuevoFactura.NumeroFactura = int.Parse(linea.Substring(PlantillaFactura.NumeroFacturaDesde, PlantillaFactura.NumeroFacturaCantidad));
                nuevoFactura.TipoFactura = linea.Substring(PlantillaFactura.TipoFacturaDesde, PlantillaFactura.TipoFacturaCantidad);
                nuevoFactura.Fecha = DateTime.Parse(linea.Substring(PlantillaFactura.FechaDesde, PlantillaFactura.FechaCantidad));
                nuevoFactura.EmpleadoId = long.Parse(linea.Substring(PlantillaFactura.EmpleadoIdDesde, PlantillaFactura.EmpleadoIdCantidad));
                nuevoFactura.ClienteId = long.Parse(linea.Substring(PlantillaFactura.ClienteIdDesde, PlantillaFactura.ClienteIdCantidad));
                nuevoFactura.Descuento = decimal.Parse(linea.Substring(PlantillaFactura.DescuentoDesde, PlantillaFactura.DescuentoCantidad));

                Facturas.Add(nuevoFactura);
            }

            //DetalleFacutras
            string[] detalleFacturas = File.ReadAllLines(detalleDelArchivo);

            foreach (var linea2 in detalleFacturas)
            {
                if (string.IsNullOrEmpty(linea2)) continue;

                var nuevoDetalleFactura = new DetalleFactura();

                nuevoDetalleFactura.Id = long.Parse(linea2.Substring(PlantillaDetalleFactura.IdDesde, PlantillaDetalleFactura.IdCantidad));
                nuevoDetalleFactura.NumeroFactura = int.Parse(linea2.Substring(PlantillaDetalleFactura.NumeroFacturaDesde, PlantillaDetalleFactura.NumeroFacturaCantidad));
                nuevoDetalleFactura.CodigoProducto = int.Parse(linea2.Substring(PlantillaDetalleFactura.CodigoProductoDesde, PlantillaDetalleFactura.CodigoProductoCantidad));
                nuevoDetalleFactura.DescripcionProducto = linea2.Substring(PlantillaDetalleFactura.DescripcionProductoDesde, PlantillaDetalleFactura.DescripcionProductoCantidad);
                nuevoDetalleFactura.PrecioUnitario = decimal.Parse(linea2.Substring(PlantillaDetalleFactura.PrecioUnitarioDesde, PlantillaDetalleFactura.PrecioUnitarioCantidad));
                nuevoDetalleFactura.Cantidad = decimal.Parse(linea2.Substring(PlantillaDetalleFactura.CantidadDesde, PlantillaDetalleFactura.CantidadCantidad));

                DetalleFacturas.Add(nuevoDetalleFactura);
                //DetalleFacturas = DetalleFacturas.Where(x => x.NumeroFactura = )
            }

        }

        // Agregar de Factura
        public static void AgregarFactura(Factura nuevaFactura) 
        {       
            var archivoFactura = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevaFactura.NumeroFactura.ToString().PadRight(PlantillaFactura.NumeroFacturaCantidad, ' ')}"
                             + $"{nuevaFactura.TipoFactura.PadRight(PlantillaFactura.TipoFacturaCantidad, ' ')}"
                             + $"{nuevaFactura.Fecha.Day.ToString().PadLeft(2, '0')}/{nuevaFactura.Fecha.Month.ToString().PadLeft(2, '0')}/{nuevaFactura.Fecha.Year.ToString().PadLeft(4, '0')}"
                             + $"{nuevaFactura.EmpleadoId.ToString().PadRight(PlantillaFactura.EmpleadoIdCantidad, ' ')}"
                             + $"{nuevaFactura.ClienteId.ToString().PadRight(PlantillaFactura.ClienteIdCantidad, ' ')}"
                             + $"{nuevaFactura.SubTotal.ToString().PadRight(PlantillaFactura.SubTotalCantidad, ' ')}"
                             + $"{nuevaFactura.Descuento.ToString().PadRight(PlantillaFactura.DescuentoCantidad, ' ')}"
                             + $"{nuevaFactura.Total.ToString().PadRight(PlantillaFactura.TotalCantidad, ' ')}";

            archivoFactura.WriteLine(crearLinea);
            archivoFactura.Close();

            Facturas.Add(nuevaFactura);
        }

        // Agregar de DetalleFactura
        public static void AgregarDetalleFactura(DetalleFactura nuevoDetalleFactura)
        {
            nuevoDetalleFactura.Id = DetalleFacturas.Any()
               ? DetalleFacturas.Max(x => x.Id) + 1
               : 1;

            var archivoDetalleFactura = new StreamWriter(detalleDelArchivo, true);

            var crearLinea = $"{nuevoDetalleFactura.Id.ToString().PadRight(PlantillaDetalleFactura.IdCantidad, ' ')}"
                             + $"{nuevoDetalleFactura.NumeroFactura.ToString().PadRight(PlantillaDetalleFactura.NumeroFacturaCantidad, ' ')}"
                             + $"{nuevoDetalleFactura.CodigoProducto.ToString().PadRight(PlantillaDetalleFactura.CodigoProductoCantidad, ' ')}"
                             + $"{nuevoDetalleFactura.DescripcionProducto.PadRight(PlantillaDetalleFactura.DescripcionProductoCantidad, ' ')}"
                             + $"{nuevoDetalleFactura.PrecioUnitario.ToString().PadRight(PlantillaDetalleFactura.PrecioUnitarioCantidad, ' ')}"
                             + $"{nuevoDetalleFactura.Cantidad.ToString().PadRight(PlantillaDetalleFactura.CantidadCantidad, ' ')}";

            archivoDetalleFactura.WriteLine(crearLinea);
            archivoDetalleFactura.Close();

            DetalleFacturas.Add(nuevoDetalleFactura);
        }

        public static List<DetalleFactura> ObtenerDetalleFactura(string cadenaBuscar)
        {
            return DetalleFacturas.Where(x => x.NumeroFactura.ToString().Contains(cadenaBuscar))
                .ToList();
        }



        //public static List<FacturaDto> ObtenerFacturaDtoo(string cadenaBuscar)
        //{
        //    return Facturas.Where(x => x.ApyNomCliente.Contains(cadenaBuscar);


        //}
    }
}
