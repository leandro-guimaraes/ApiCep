using Microsoft.EntityFrameworkCore;

namespace ApiMinima.Model
{
     class EnderecoDb : DbContext
    {
        public EnderecoDb(DbContextOptions<EnderecoDb> options) 
        : base(options){ }

        public DbSet<Endereco> Enderecos => Set<Endereco>();
    }
}
