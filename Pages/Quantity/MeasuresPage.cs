using System.Collections.Generic;
using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage : PageModel
    {
        protected internal readonly IMeasuresRepository db;

        protected internal MeasuresPage(IMeasuresRepository r) => db = r;

        [BindProperty]
        public MeasureView Item { get; set; }

        public IList<MeasureView> Items { get; set; }

        public string PageTitle { get; set; } = "Mingi pealkiri";

        public string CurrentSort { get; set; } = "Current Sort";

        public string CurrentFilter { get; set; } = "Current Filter";

        public int PageIndex { get; set; } = 3;

        public int TotalPages { get; set; } = 10;
    }
}
