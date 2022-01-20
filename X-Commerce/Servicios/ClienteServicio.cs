using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class ClienteServicio
    {
        public static string nombreDelArchivo = $@"{Environment.CurrentDirectory}\Clientes.txt";

        public static List<Cliente> Clientes = new List<Cliente>();
     
        public static void ObtenerClientesDelArchivo() 
        {
            string[] clientes = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in clientes)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                var nuevoCliente = new Cliente();

                nuevoCliente.Id = long.Parse(linea.Substring(PlantillaCliente.IdDesde, PlantillaCliente.IdCantidad));
                nuevoCliente.Codigo = int.Parse(linea.Substring(PlantillaCliente.CodigoDesde, PlantillaCliente.CodigoCantidad));
                nuevoCliente.Apellido = linea.Substring(PlantillaCliente.ApellidoDesde, PlantillaCliente.ApellidoCantidad).Trim();
                nuevoCliente.Nombre = linea.Substring(PlantillaCliente.NombreDesde, PlantillaCliente.NombreCantidad).Trim();
                nuevoCliente.Dni = linea.Substring(PlantillaCliente.DniDesde, PlantillaCliente.DniCantidad);
                nuevoCliente.FechaNacimiento = DateTime.Parse(linea.Substring(PlantillaCliente.FechaNacimientoDesde, PlantillaCliente.FechaNacimientoCantidad));
                nuevoCliente.Calle = linea.Substring(PlantillaCliente.CalleDesde, PlantillaCliente.CalleCantidad).Trim();
                nuevoCliente.Numero = linea.Substring(PlantillaCliente.NumeroDesde, PlantillaCliente.NumeroCantidad).Trim();
                nuevoCliente.Piso = linea.Substring(PlantillaCliente.PisoDesde, PlantillaCliente.PisoCantidad).Trim();
                nuevoCliente.Departamento = linea.Substring(PlantillaCliente.DepartamentoDesde, PlantillaCliente.DepartamentoCantidad).Trim();
                nuevoCliente.ActivarLimiteCompra = bool.Parse(linea.Substring(PlantillaCliente.ActivarLimiteCompraDesde, PlantillaCliente.ActivarLimiteCompraCantidad));
                nuevoCliente.MontoLimiteCompra = decimal.Parse(linea.Substring(PlantillaCliente.MontoLimiteCompraDesde, PlantillaCliente.MontoLimiteCompraCantidad));

                Clientes.Add(nuevoCliente);
            }
        }

        public static void Agregar(Cliente nuevoCliente) 
        {
            nuevoCliente.Id = Clientes.Any()
                ? Clientes.Max(x => x.Id) + 1
                : 1;

            var archivoCliente = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevoCliente.Id.ToString().PadRight(PlantillaCliente.IdCantidad, ' ')}"
                             + $"{nuevoCliente.Codigo.ToString().PadRight(PlantillaCliente.CodigoCantidad, ' ')}"
                             + $"{nuevoCliente.Apellido.PadRight(PlantillaCliente.ApellidoCantidad, ' ')}"
                             + $"{nuevoCliente.Nombre.PadRight(PlantillaCliente.NombreCantidad, ' ')}"
                             + $"{nuevoCliente.Dni.PadLeft(PlantillaCliente.DniCantidad, '0')}"
                             + $"{nuevoCliente.FechaNacimiento.Day.ToString().PadLeft(2, '0')}/{nuevoCliente.FechaNacimiento.Month.ToString().PadLeft(2, '0')}/{nuevoCliente.FechaNacimiento.Year.ToString().PadLeft(4, '0')}"
                             + $"{nuevoCliente.Calle.PadRight(PlantillaCliente.CalleCantidad, ' ')}"
                             + $"{nuevoCliente.Numero.PadRight(PlantillaCliente.NumeroCantidad, ' ')}"
                             + $"{nuevoCliente.Piso.PadRight(PlantillaCliente.PisoCantidad, ' ')}"
                             + $"{nuevoCliente.Departamento.PadRight(PlantillaCliente.DepartamentoCantidad, ' ')}"
                             + $"{nuevoCliente.ActivarLimiteCompra.ToString().PadLeft(PlantillaCliente.ActivarLimiteCompraCantidad, ' ')}"
                             + $"{nuevoCliente.MontoLimiteCompra.ToString().PadRight(PlantillaCliente.MontoLimiteCompraCantidad, ' ')}";

            archivoCliente.WriteLine(crearLinea);
            archivoCliente.Close();

            Clientes.Add(nuevoCliente);                                    
        }
    
        public static int ObtenerSiguienteCodigo()
        {
            return Clientes.Any() // Pregunto si tiene algun registro cargado
                ? Clientes.Max(x => x.Codigo) + 1 // Obtengo el valor maximo del legajo + 1
                : 1;
        }

        public static List<Cliente> Obtener(string cadenaBuscar)
        {
            return Clientes.Where(x => x.Apellido.Contains(cadenaBuscar)
                                        || x.Nombre.Contains(cadenaBuscar)
                                        || x.Dni == cadenaBuscar)
                .ToList();           
        }

        public static long ObtenerId(string codigo)
        {
            var cliente = Clientes.Where(x => x.Codigo.ToString().Contains(codigo)).FirstOrDefault();
            return cliente.Id;
        }
    }
}
