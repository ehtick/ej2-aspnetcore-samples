#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;
using EJ2CoreSampleBrowser.Models;

namespace EJ2CoreSampleBrowser_NET8.Pages.Grid;

public class RowDragAndDropModel : PageModel
{
    public List<OrdersDetails> DataSource { get; set; }

    public void OnGet()
    {
        var order = OrdersDetails.GetAllRecords();
        DataSource = order.Take(24).ToList();
    }
}