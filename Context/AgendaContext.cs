using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__auala_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace C__auala_MVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {
            
        }
        public DbSet<Contato> Contatos {get; set;}
    }
}