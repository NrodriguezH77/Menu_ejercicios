using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEstudiantes
{
    public class Estudiante
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }
        public double notaFinal { get; set; }
        public string notaConcepto { get; set; }
    
    }
}
