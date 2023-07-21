using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TrabalhandoComEF.context
{
    public class AgendaContext : DbContext
    {
       public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
       {
        
       } 

       
    }
}