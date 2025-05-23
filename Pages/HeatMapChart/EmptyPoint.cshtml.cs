#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser.Pages.HeatMapChart;

public class EmptyPoint : PageModel
{
    public int?[,] dataSource = new int?[11, 12]
    {
        { 8, 5, 2, 6, 8, 2, 9, 3, 7, 8, 7, 6 },
        { 5, null, 4, 9, 10, null, 11, 7, 3, 7, 8, null },
        { 8, 7, 2, null, 5, 3, null, 2, 1, 8, null, 4 },
        { 10, 2, null, 4, 5, null, 1, 10, 5, 2, 1, null },
        { 1, 2, 9, 4, null, 5, 1, null, 12, 1, null, 4 },
        { 4, null, 3, 5, 2, null, null, null, 5, null, 1, 3 },
        { null, null, 4, 10, null, 5, 11, 2, 8, 1, null, 1 },
        { 1, 4, null, 4, 5, null, 1, 3, null, 1, null, 3 },
        { null, 2, 1, 4, null, 5, 1, null, 2, 1, null, 2 },
        { 1, null, 4, null, null, 2, null, 5, 1, 5, 2, 1 },
        { 1, null, 2, 1, 5, null, null, null, 5, 2, 1, null }
    };
    public void OnGet()
    {
        
    }
}