#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EJ2CoreSampleBrowser.Models;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.EJ2.Base;

namespace EJ2CoreSampleBrowser.Controllers.Grid
{
    public partial class GridController : Controller
    {
        public IActionResult DialogTemplate()
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            return View();
        }

        public IActionResult EditPartial([FromBody] CRUDModel<DialogTemplateModel> value)
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            return PartialView("_DialogEditPartial", value.Value);
        }

        public IActionResult AddPartial([FromBody] CRUDModel<DialogTemplateModel> value)
        {
            var order = OrdersDetails.GetAllRecords();
            ViewBag.datasource = order;
            return PartialView("_DialogAddPartial");
        }
    }
}