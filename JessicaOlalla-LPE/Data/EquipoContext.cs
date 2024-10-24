using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JessicaOlalla_LPE.Models;

    public class EquipoContext : DbContext
    {
        public EquipoContext (DbContextOptions<EquipoContext> options)
            : base(options)
        {
        }

        public DbSet<JessicaOlalla_LPE.Models.Equipo> Equipo { get; set; } = default!;

        public DbSet<JessicaOlalla_LPE.Models.Jugador> Jugador { get; set; } = default!;

        public DbSet<JessicaOlalla_LPE.Models.Estadio> Estadio { get; set; } = default!;
    }
