using System;

namespace X_Commerce.Entidades
{
    public class Cliente
    {
        public long Id { get; set; }

        public int Codigo { get; set; }

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
                var direccion = $"{Calle} Nro: {Numero}";

                if (!string.IsNullOrEmpty(Piso))
                {
                    direccion += $" Piso: {Piso}";
                }

                if (!string.IsNullOrEmpty(Departamento))
                {
                    direccion += $" Dpto: {Departamento}";
                }

                return direccion;
            }
        }

        public bool ActivarLimiteCompra { get; set; }

        public decimal MontoLimiteCompra { get; set; }

    }
}
