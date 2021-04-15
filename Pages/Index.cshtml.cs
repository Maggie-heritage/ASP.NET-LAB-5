using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorServerExample.Models;

namespace BlazorServerExample.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlazorServerExample.Models.BlogContext _context;

        public IndexModel(BlazorServerExample.Models.BlogContext context)
        {
            _context = context;
        }

        public IList<BlogEntry> BlogEntry { get;set; }

        public async Task OnGetAsync()
        {
            BlogEntry = await _context.Entries.ToListAsync();
        }
    }
}
