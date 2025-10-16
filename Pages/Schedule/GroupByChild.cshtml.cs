#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;
using EJ2CoreSampleBrowser.Models;
namespace EJ2CoreSampleBrowser.Pages.Schedule;

public class GroupByChild : PageModel
{
    public List<ResourceDataSourceModel> projects = new List<ResourceDataSourceModel>();
    public List<ResourceDataSourceModel> categories = new List<ResourceDataSourceModel>();
    public void OnGet()
    {
        projects.Add(new ResourceDataSourceModel { text = "PROJECT 1", id = 1, color = "#cb6bb2" });
        projects.Add(new ResourceDataSourceModel { text = "PROJECT 2", id = 2, color = "#56ca85" });
        
        categories.Add(new ResourceDataSourceModel { text = "Development", id = 1, color = "#df5286" });
        categories.Add(new ResourceDataSourceModel { text = "Testing", id = 2, color = "#7fa900" });
    }
}