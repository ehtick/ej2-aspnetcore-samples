#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;
using Syncfusion.EJ2.QueryBuilder;

namespace EJ2CoreSampleBrowser_NET8.Pages.QueryBuilder;

public class RuleTemplateModel : PageModel
{
    public QueryBuilderRule rule { get; set; }

    public void OnGet()
    {
        rule = new QueryBuilderRule()
        {
            Condition = "and",
            Rules = new List<QueryBuilderRule>()
            {
                new QueryBuilderRule { Label="First Name", Field="FirstName", Type="string", Operator="equal", Value="Nancy"  },
                new QueryBuilderRule { Label="Country", Field="Country", Type="string", Operator="equal", Value = "USA" }
            }
        };
    }
}