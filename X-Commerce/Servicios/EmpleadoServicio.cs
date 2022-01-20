using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class EmpleadoServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}\Empleados.txt";

        public static List<Empleado> Empleados = new List<Empleado>();

        public static void ObtenerEmpleadosDelArchivo()
        {
            string[] empleados = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in empleados)
            {
                if (string.IsNullOrEmpty(linea)) continue;

                var nuevoEmpleado = new Empleado();

                nuevoEmpleado.Id = long.Parse(linea.Substring(PlantillaEmpleado.IdDesde, PlantillaEmpleado.IdCantidad));
                nuevoEmpleado.Legajo = int.Parse(linea.Substring(PlantillaEmpleado.LegajoDesde, PlantillaEmpleado.LegajoCantidad));
                nuevoEmpleado.Apellido = linea.Substring(PlantillaEmpleado.ApellidoDesde, PlantillaEmpleado.ApellidoCantidad).Trim();
                nuevoEmpleado.Nombre = linea.Substring(PlantillaEmpleado.NombreDesde, PlantillaEmpleado.NombreCantidad).Trim();
                nuevoEmpleado.Dni = linea.Substring(PlantillaEmpleado.DniDesde, PlantillaEmpleado.DniCantidad);
                nuevoEmpleado.FechaNacimiento = DateTime.Parse(linea.Substring(PlantillaEmpleado.FechaDeNacimientoDesde, PlantillaEmpleado.FechaDeNacimientoCantidad));
                nuevoEmpleado.Calle = linea.Substring(PlantillaEmpleado.CalleDesde, PlantillaEmpleado.CalleCantidad).Trim();
                nuevoEmpleado.Numero = linea.Substring(PlantillaEmpleado.NumeroDesde, PlantillaEmpleado.NumeroCantidad).Trim();
                nuevoEmpleado.Piso = linea.Substring(PlantillaEmpleado.PisoDesde, PlantillaEmpleado.PisoCantidad).Trim();
                nuevoEmpleado.Departamento = linea.Substring(PlantillaEmpleado.DepartamentoDesde, PlantillaEmpleado.DepartamentoCantidad).Trim();

                Empleados.Add(nuevoEmpleado);
            }
        }

        public static void Agregar (Empleado nuevoEmpleado)
        {
            // Obtiene un Identificador Unico para el nuevo Empleado
            nuevoEmpleado.Id = Empleados.Any()
                ? Empleados.Max(x => x.Id) + 1
                : 1;

            //Agregar al archivo
            var archivoEmpleado = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevoEmpleado.Id.ToString().PadRight(PlantillaEmpleado.IdCantidad, ' ')}"
                             +$"{nuevoEmpleado.Legajo.ToString().PadLeft(PlantillaEmpleado.LegajoCantidad, ' ')}"
                             +$"{nuevoEmpleado.Apellido.PadRight(PlantillaEmpleado.ApellidoCantidad, ' ')}"
                             +$"{nuevoEmpleado.Nombre.PadRight(PlantillaEmpleado.NombreCantidad, ' ')}"
                             +$"{nuevoEmpleado.Dni.PadLeft(PlantillaEmpleado.DniCantidad, '0')}"
                             +$"{nuevoEmpleado.FechaNacimiento.Day.ToString().PadLeft(2, '0')}/{nuevoEmpleado.FechaNacimiento.Month.ToString().PadLeft(2, '0')}/{nuevoEmpleado.FechaNacimiento.Year.ToString().PadLeft(4, '0')}"
                             +$"{nuevoEmpleado.Calle.PadRight(PlantillaEmpleado.CalleCantidad, ' ')}" 
                             +$"{nuevoEmpleado.Numero.PadRight(PlantillaEmpleado.NumeroCantidad, ' ')}"
                             +$"{nuevoEmpleado.Piso.PadRight(PlantillaEmpleado.PisoCantidad, ' ')}"
                             +$"{nuevoEmpleado.Departamento.PadRight(PlantillaEmpleado.DepartamentoCantidad, ' ')}";
            
            archivoEmpleado.WriteLine(crearLinea);
            archivoEmpleado.Close();

            // Agregar a la lista estatica
            Empleados.Add(nuevoEmpleado);

            // Creacion de usuario
            UsuarioServicio.CrearUsuario(nuevoEmpleado.Id, nuevoEmpleado.Apellido, nuevoEmpleado.Nombre);
        } 

    
        public static int ObtenerSiguienteLegajo()
        {
            return Empleados.Any() // Pregunto si tiene algun registro cargado
                ? Empleados.Max(x => x.Legajo) + 1 // Obtengo el valor maximo del legajo + 1
                : 1;
        }
            
        public static Empleado ObtenerNombreUsuario (string nombreUsuario)
        {
            var usuario = SeguridadServicio.Usuarios.FirstOrDefault(x => x.NombreUsuario == nombreUsuario);

            if (usuario == null) throw new Exception("El usuario no Existe");

            return Empleados.FirstOrDefault(x => x.Id == usuario.EmpleadoId);
        }

        public static Empleado Obtener(long id)
        {
            return Empleados.FirstOrDefault(x => x.Id == id);
        }

        public static List<Empleado> Obtener(string cadenaBuscar)
        {
            return Empleados.Where(x => x.Apellido.Contains(cadenaBuscar)
                                        || x.Nombre.Contains(cadenaBuscar)
                                        || x.Dni == cadenaBuscar)
                .ToList();
        }
    }
}
