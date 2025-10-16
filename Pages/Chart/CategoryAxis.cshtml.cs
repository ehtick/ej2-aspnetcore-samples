#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser.Pages.Chart
{
    public class CategoryAxisModel : PageModel
    {
        public List<CategoryAxisData> ChartPoints { get; set; }
        public void OnGet()
        {
            ChartPoints = new List<CategoryAxisData>
            {
                new CategoryAxisData { Country = "Germany", Users = 72, TooltipMappingName = "GER: 72" },
                new CategoryAxisData { Country = "Russia", Users = 103.1, TooltipMappingName = "RUS: 103.1" },
                new CategoryAxisData { Country = "Brazil", Users = 139.1, TooltipMappingName = "BRZ: 139.1" },
                new CategoryAxisData { Country = "India", Users = 462.1, TooltipMappingName = "IND: 462.1" },
                new CategoryAxisData { Country = "China", Users = 721.4, TooltipMappingName = "CHN: 721.4" },
                new CategoryAxisData { Country = "United States<br>Of America", Users = 286.9, TooltipMappingName = "USA: 286.9" },
                new CategoryAxisData { Country = "Great Britain", Users = 115.1, TooltipMappingName = "GBR: 115.1" },
                new CategoryAxisData { Country = "Nigeria", Users = 97.2, TooltipMappingName = "NGR: 97.2" }
            };
        }
    }
    public class CategoryAxisData
    {
        public string Country;
        public double Users;
        public string TooltipMappingName;
    }
}
