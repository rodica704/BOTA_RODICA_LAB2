using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BOTA_RODICA_LAB2.Models;

namespace BOTA_RODICA_LAB2.Data
{
    public class BOTA_RODICA_LAB2Context : DbContext
    {
        public BOTA_RODICA_LAB2Context (DbContextOptions<BOTA_RODICA_LAB2Context> options)
            : base(options)
        {
        }

        public DbSet<BOTA_RODICA_LAB2.Models.Book> Book { get; set; } = default!;

        public DbSet<BOTA_RODICA_LAB2.Models.Publisher>? Publisher { get; set; }
    }
}
