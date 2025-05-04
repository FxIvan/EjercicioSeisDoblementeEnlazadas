using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTres
{
    public class Precio
    {
        public int EdadMin { get; set; }
        public int EdadMax { get; set; }
        public int Monto { get; set; }
    }

    public class Espectador
    {
        public string Nombre { get; set; }
        public decimal Monto { get; set; }
        public int Edad { get; set; }

        public bool IsNew { get; set; }

        public override string ToString()
        {
            return $"{Nombre} - Edad: {Edad} - Monto: ${Monto}";
        }
    }

    public class DatosGlobales
    {
        // Array público y estático de nombres
        public static string[] Nombres = new string[]
        {
            "Ana", "Luis", "Carlos", "María", "Pedro",
            "Lucía", "Javier", "Sofía", "Miguel", "Laura",
            "Diego", "Valentina", "Andrés", "Camila", "Mateo",
            "Isabel", "Tomás", "Elena", "Nicolás", "Paula"
        };
    }
}
