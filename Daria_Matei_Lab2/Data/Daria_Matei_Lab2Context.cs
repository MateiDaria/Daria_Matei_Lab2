using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Daria_Matei_Lab2.Models;

namespace Daria_Matei_Lab2.Data
{
    public class Daria_Matei_Lab2Context : DbContext
    {
        public Daria_Matei_Lab2Context (DbContextOptions<Daria_Matei_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Daria_Matei_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Daria_Matei_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Daria_Matei_Lab2.Models.Author> Author { get; set; }
    }
}
