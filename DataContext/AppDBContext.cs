using Microsoft.EntityFrameworkCore;
using Salus_2._0.Models;

namespace Salus_2._0.DataContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        /*  Tabelas já existentes no banco antes de utilizar Migrations
         *  Commands:
         * 
         *  Inserir o migration desejado para criar tabela ao banco
         *      public DbSet<UsuarioModel> Usuario { get; set; }
         
         *  Em seguida rodar o comando de criar o Migration da tabela
         *      add-migration Usuario
         
         *  Se sucesso rodar o comando para criar no BD
         *      update-database 
         * 
         */

        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<RegisterModel> Register { get; set; }
        public DbSet<ClienteModel> Cliente {  get; set; }
        public DbSet<ContatoModel> Contato { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<UsuarioModel>().Metadata.SetIsTableExcludedFromMigrations(true);
        //}

    }
}
