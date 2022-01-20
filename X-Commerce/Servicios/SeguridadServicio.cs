using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using X_Commerce.Entidades;
using X_Commerce.PlantillasDeCorte;

namespace X_Commerce.Servicios
{
    public static class SeguridadServicio
    {
        private static string nombreDelArchivo = $@"{Environment.CurrentDirectory}\Usuarios.txt";

        public static List<Usuario> Usuarios = new List<Usuario>();

        public static void ObtenerDatosDelArchivo()
        {
            string[] usuarios = File.ReadAllLines(nombreDelArchivo);

            foreach (var linea in usuarios)
            {
                var nuevoUsuario = new Usuario();

                nuevoUsuario.EmpleadoId = long.Parse(linea.Substring(PlantillaUsuario.EmpleadoIdDesde, PlantillaUsuario.EmpleadoIdCantidad));
                nuevoUsuario.NombreUsuario = linea.Substring(PlantillaUsuario.NombreDesde, PlantillaUsuario.NombreCantidad).Trim();
                nuevoUsuario.Password = linea.Substring(PlantillaUsuario.PasswordDesde, PlantillaUsuario.PasswordCantidad).Trim();

                Usuarios.Add(nuevoUsuario);
            }
        }

        public static bool VerificarSiExiste(string usuario, string password)
        {
            return Usuarios.Any(usu => usu.NombreUsuario == usuario && usu.Password == password);
        }

    }
}
