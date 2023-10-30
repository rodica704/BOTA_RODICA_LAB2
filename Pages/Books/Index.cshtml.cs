using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BOTA_RODICA_LAB2.Data;
using BOTA_RODICA_LAB2.Models;

namespace BOTA_RODICA_LAB2.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BOTA_RODICA_LAB2.Data.BOTA_RODICA_LAB2Context _context;

        public IndexModel(BOTA_RODICA_LAB2.Data.BOTA_RODICA_LAB2Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book
                    .Include(b => b.Publisher)
                    .ToListAsync();
               
            }
        }
    }
}
