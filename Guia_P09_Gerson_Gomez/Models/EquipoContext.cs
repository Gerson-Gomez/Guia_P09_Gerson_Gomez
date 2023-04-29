using Microsoft.EntityFrameworkCore;

namespace Guia_P09_Gerson_Gomez.Models
{
    public class EquipoContext : DbContext
    {
        public EquipoContext(DbContextOptions<EquipoContext> options) : base(options)
        {

        }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        //public DbSet<TipoEquipos> tipo_equipo { get; set; }
        //public DbSet<EstadosEquipos> estados_equipo { get; set; }
        //public DbSet<EstadosReserva> estados_reserva { get; set; }
        //public DbSet<Carreras> carreras { get; set; }
        //public DbSet<Facultades> facultades { get; set; }
        //public DbSet<Reserva> reservas { get; set; }
        //public DbSet<Usuario> usuarios { get; set; }
    }
}
