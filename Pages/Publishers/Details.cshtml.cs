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
    public class DetailsModel : PageModel
    {
        private readonly BOTA_RODICA_LAB2.Data.BOTA_RODICA_LAB2Context _context;

        public DetailsModel(BOTA_RODICA_LAB2.Data.BOTA_RODICA_LAB2Context context)
        {
            _context = context;
        }

      public Publisher Publisher { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Publisher == null)
            {
                return NotFound();
            }

            var publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.Id == id);
            if (publisher == null)
            {
                return NotFound();
            }
            else 
            {
                Publisher = publisher;
            }
            return Page();
        }
    }
}
