using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using prueba.Models;

    public class pruebaContext : DbContext
    {
        public pruebaContext (DbContextOptions<pruebaContext> options)
            : base(options)
        {
        }

        public DbSet<prueba.Models.Categoria> Categoria { get; set; }
    }
