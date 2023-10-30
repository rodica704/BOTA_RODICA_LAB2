using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BOTA_RODICA_LAB2.Data;
using BOTA_RODICA_LAB2.Models;

namespace BOTA_RODICA_LAB2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly BOTA_RODICA_LAB2.Data.BOTA_RODICA_LAB2Context _context;

        public IndexModel(BOTA_RODICA_LAB2.Data.BOTA_RODICA_LAB2Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Publisher != null)
            {
                Publisher = await _context.Publisher.ToListAsync();
            }
        }
    }
}
