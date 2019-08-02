using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tipo.Models
{
    public class Estudiante
    {
        [Display(Name = "Estudiante")]
        public int EstudianteID { get; set; }
        [Display(Name="Acudiente")]
        public int AcudienteID { get; set; }
        public Acudiente Acudiente { get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime edad { get; set; }

    }
}
