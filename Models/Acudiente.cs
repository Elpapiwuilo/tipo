﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tipo.Models
{
    public class Acudiente
    {
        public int AcudienteID { get; set; }
        [Required]
        [StringLength(50,MinimumLength =3,ErrorMessage ="El nombre debe tener de"+"3 a 50 caracteres")]
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento  { get; set; }
        public string Telefono { get; set; }
    }
}
