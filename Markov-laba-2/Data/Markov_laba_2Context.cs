using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Markov_laba_2.Models;

namespace Markov_laba_2.Data
{
    public class Markov_laba_2Context : DbContext
    {
        public Markov_laba_2Context (DbContextOptions<Markov_laba_2Context> options)
            : base(options)
        {
        }

        public DbSet<Markov_laba_2.Models.Client> Client { get; set; } = default!;
        public DbSet<Markov_laba_2.Models.Courier> Courier { get; set; } = default!;
        public DbSet<Markov_laba_2.Models.Order> Order { get; set; } = default!;
        public DbSet<Markov_laba_2.Models.Restaurant> Restaurant { get; set; } = default!;
    }
}
