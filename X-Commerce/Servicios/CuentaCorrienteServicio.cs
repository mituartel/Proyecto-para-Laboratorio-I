using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class CuentaCorrienteServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}/CuentaCorrientes.txt";

        // Lista de Clientes para el sistema
        public static List<CuentaCorriente> CuentaCorrientess = new List<CuentaCorriente>();

        public static void ObtenerCtaCteDelArchivo()
        {
            string[] ctaCte = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in ctaCte)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                var nuevoClienteCtaCte = new CuentaCorriente();

                nuevoClienteCtaCte.Id = long.Parse(linea.Substring(PlantillaCuentaCorriente.IdDesde, PlantillaCuentaCorriente.IdCantidad));
                nuevoClienteCtaCte.ClienteId = long.Parse(linea.Substring(PlantillaCuentaCorriente.ClienteIdDesde, PlantillaCuentaCorriente.ClienteIdCantidad));
                nuevoClienteCtaCte.Descripcion = linea.Substring(PlantillaCuentaCorriente.DescripcionDesde, PlantillaCuentaCorriente.DescripcionCantidad);
                nuevoClienteCtaCte.Fecha = DateTime.Parse(linea.Substring(PlantillaCuentaCorriente.FechaDesde, PlantillaCuentaCorriente.FechaCantidad));
                nuevoClienteCtaCte.Monto = decimal.Parse(linea.Substring(PlantillaCuentaCorriente.MontoDesde, PlantillaCuentaCorriente.MontoCantidad));
                nuevoClienteCtaCte.TipoMovimiento = linea.Substring(PlantillaCuentaCorriente.TipoMovimientoDesde, PlantillaCuentaCorriente.TipoMovimientoCantidad) == "-1"
                    ? TipoMovimiento.Ingreso
                    : TipoMovimiento.Egreso;

                CuentaCorrientess.Add(nuevoClienteCtaCte);
            }
        }

        public static void Agregar(CuentaCorriente nuevoCtaCte) 
        {
            nuevoCtaCte.Id = CuentaCorrientess.Any()
                ? CuentaCorrientess.Max(x => x.Id) + 1
                : 1;

            var archivoCtaCte = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevoCtaCte.Id.ToString().PadRight(PlantillaCuentaCorriente.IdCantidad, ' ')}"
                             + $"{nuevoCtaCte.ClienteId.ToString().PadRight(PlantillaCuentaCorriente.ClienteIdCantidad, ' ')}"
                             + $"{nuevoCtaCte.Descripcion.PadRight(PlantillaCuentaCorriente.DescripcionCantidad, ' ')}"
                             + $"{nuevoCtaCte.Fecha.Day.ToString().PadLeft(2, '0')}/{nuevoCtaCte.Fecha.Month.ToString().PadLeft(2, '0')}/{nuevoCtaCte.Fecha.Year.ToString().PadLeft(4, '0')}"
                             + $"{nuevoCtaCte.Monto.ToString().PadRight(PlantillaCuentaCorriente.MontoCantidad, ' ')}"
                             + $"{nuevoCtaCte.TipoMovimiento.ToString().PadRight(PlantillaCuentaCorriente.TipoMovimientoCantidad, ' ')}";
                             
            archivoCtaCte.WriteLine(crearLinea);
            archivoCtaCte.Close();

            CuentaCorrientess.Add(nuevoCtaCte);
        }

        public static List<CuentaCorriente> Obtener(string cadenaBuscar)
        {
            return CuentaCorrientess.Where(x => x.ClienteId.ToString() == (cadenaBuscar))                                        
                                    .ToList();
        }

        public static CuentaCorriente ObtenerId(long ctaCteId)
        {
            return CuentaCorrientess.Where(x => x.ClienteId == ctaCteId).LastOrDefault();
        }

        public static void AgregarMontoNuevo(CuentaCorriente ctaCte)
        {
            var nuevoCtaCte = ObtenerId(ctaCte.ClienteId);

            nuevoCtaCte.Monto += ctaCte.Monto;

            Agregar(nuevoCtaCte);
        }
    }
}
