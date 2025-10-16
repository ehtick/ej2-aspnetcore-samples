#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EJ2CoreSampleBrowser.Pages.ThreeDimensionsChart;

public class BarModel : PageModel
{
    public List<BarChartData> ChartPoints { get; set; }
    public void OnGet()
    {
        ChartPoints = new List<BarChartData>
        {
            new BarChartData { X = "Japan",    Y = 1.71,  Y1 = 6.02 },
            new BarChartData { X = "France",   Y = 1.82,  Y1 = 3.19 },
            new BarChartData { X = "India",    Y = 6.68,  Y1 = 3.28 },
            new BarChartData { X = "Germany",  Y = 2.22,  Y1 = 4.56 },
            new BarChartData { X = "Italy",    Y = 1.50,  Y1 = 2.40 },
            new BarChartData { X = "Canada",   Y = 3.05,  Y1 = 2.04 }
        };
    }
}
public class BarChartData
{
    public string X;
    public double Y;
    public double Y1;
}