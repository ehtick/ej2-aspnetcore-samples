#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using EJ2CoreSampleBrowser.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser.Pages.TreeGrid
{
    public class CustomContextMenuModel : PageModel
    {
        public List<object> ContextItems { get; set; }

        public void OnGet()
        {
            ContextItems = new List<Object>();
            ContextItems.Add(new { text = "Collapse the Row", target = ".e-content", id = "collapserow" });
            ContextItems.Add(new { text = "Expand the Row", target = ".e-content", id = "expandrow" });

        }
        
    }
}