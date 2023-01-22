using Microsoft.EntityFrameworkCore;
using MsPaciente.Api.Models;
using System.Collections.Generic;

namespace MsPaciente.Api.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
