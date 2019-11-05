using CRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Data
{
    public class CRUDEFContext : DbContext
    {
        public CRUDEFContext(DbContextOptions<CRUDEFContext> options) : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}
