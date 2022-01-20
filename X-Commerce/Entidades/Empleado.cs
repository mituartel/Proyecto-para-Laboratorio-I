using System;

namespace X_Commerce.Entidades
{
    public class Empleado
    {
        public long Id { get; set; }

        public int Legajo { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string ApyNom => $"{Apellido}, {Nombre}";

        public string Dni { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string FechaNacimientoStr => FechaNacimiento.ToShortDateString();

        public string Calle { get; set; }

        public string Numero { get; set; }

        public string Piso { get; set; }

        public string Departamento { get; set; }

        public string DireccionCompleta
        {
            get
            {
                var domicilio = $"{Calle} Nro: {Numero}";

                if (!string.IsNullOrEmpty(Piso))
                {
                    domicilio += $" Piso: {Piso}";
                }

                if (!string.IsNullOrEmpty(Departamento))
                {
                    domicilio += $" Departamento: {Departamento}";
                }

                return domicilio;
            }
        }

    }
}
