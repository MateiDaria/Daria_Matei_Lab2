using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Daria_Matei_Lab2.Data;
using Daria_Matei_Lab2.Models;

namespace Daria_Matei_Lab2.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Daria_Matei_Lab2.Data.Daria_Matei_Lab2Context _context;

        public IndexModel(Daria_Matei_Lab2.Data.Daria_Matei_Lab2Context context)
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
