using System;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class UsuarioServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}\Usuarios.txt";

        public static void CrearUsuario(long empleadoId, string empleadoApellido, string empleadoNombre)
        {
            var nuevoUsuario = new Usuario();

            nuevoUsuario.EmpleadoId = empleadoId;
            nuevoUsuario.NombreUsuario = ObtenerNombre(empleadoApellido, empleadoNombre);
            nuevoUsuario.Password = "1234";

            // Grabamos en la lista Statica de Seguridad para poder Loguearnos
            SeguridadServicio.Usuarios.Add(nuevoUsuario);

            // Grabar en el Archivo de Usuario
            var archivoUsuario = new StreamWriter(nombreDelArchivo, true);

            var crearLinea = $"{nuevoUsuario.EmpleadoId.ToString().PadLeft(PlantillaUsuario.EmpleadoIdCantidad, '0')}"
                             + $"{nuevoUsuario.NombreUsuario.ToString().PadRight(PlantillaUsuario.NombreCantidad, ' ')}"
                             + $"{nuevoUsuario.Password.ToString().PadRight(PlantillaUsuario.PasswordCantidad, ' ')}";

            archivoUsuario.WriteLine(crearLinea);
            archivoUsuario.Close();
        }

        public static string ObtenerNombre(string apellido, string nombre)
        {
            int contadorLetras = 1;

            string nombreUsuarioNuevo = $"{nombre.Trim().Substring(0, contadorLetras)}{apellido.Trim()}";

            while (SeguridadServicio.Usuarios.Any(x => x.NombreUsuario == nombreUsuarioNuevo.ToLower()))
            {
                contadorLetras ++;

                nombreUsuarioNuevo = $"{nombre.Trim().Substring(0, contadorLetras)}{apellido.Trim()}";
            }

            return nombreUsuarioNuevo.ToLower();
        }
    }
}
