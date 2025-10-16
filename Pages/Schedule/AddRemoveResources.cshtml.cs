#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser.Pages.Schedule;

public class AddRemoveResources : PageModel
{
    public List<CalendarResource> calendarCollections = new List<CalendarResource>();
    public void OnGet()
    {
        calendarCollections.Add(new CalendarResource { CalendarName = "My Calendar", CalendarId = 1, CalendarColor = "#c43081" });
    }
}
public class CalendarResource
{
    public string CalendarName { set; get; }
    public int CalendarId { set; get; }
    public string CalendarColor { set; get; }
}