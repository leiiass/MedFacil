using MedFacil.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MedFacil.Infraestruura.BancoDeDados
{
    public class BancoDeDadosConfig : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        public const string DbCaminho = "Data Source=LEIAMENDES;Initial Catalog=DbMedFacil;Integrated Security=True;Encrypt=False";

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer(DbCaminho);
    }
}