using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tipo.Models;

    public class tipoContext : DbContext
    {
        public tipoContext (DbContextOptions<tipoContext> options)
            : base(options)
        {
        }

        public DbSet<tipo.Models.Acudiente> Acudiente { get; set; }

        public DbSet<tipo.Models.Estudiante> Estudiante { get; set; }

        public DbSet<tipo.Models.Juego> Juego { get; set; }
    }
