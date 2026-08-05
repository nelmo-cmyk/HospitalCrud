using HospitalCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalCrud.DataContext
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext>options):base(options)
        {
            
        }
    
        public DbSet<Paciente> Pacientes { get; set; }

    }
}
