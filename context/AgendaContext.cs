using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrabalhandoComEF.Entities;

namespace TrabalhandoComEF.context
{
    public class AgendaContext : DbContext
    {
       // Recebe a conexão do banco e passa para o dbcontext que gerencia a conexão do banco de dados
       public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
       {
            
       }

       public DbSet<Contato> Contatos { get; set; }

    }
}