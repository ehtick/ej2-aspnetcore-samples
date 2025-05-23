#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Parsing;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;

namespace EJ2CoreSampleBrowser.Pages.Pdf;

public class Booklet : PageModel
{
    public void OnGet()
    {
        
    }
    private readonly IWebHostEnvironment _hostingEnvironment;
    public Booklet(IWebHostEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }
    [HttpPost]
    public ActionResult OnPost(string PageHeight, string PageWidth, string CheckBoxDoubleSide, string InsideBrowser)
    {
        try
        {
            if (String.IsNullOrEmpty(PageWidth) || String.IsNullOrEmpty(PageHeight))
            {

                ViewData["Error"] = "Please ensure the width and height for the page to be updated.";
            }
            else
            {
                string basePath = _hostingEnvironment.WebRootPath;
                string dataPath = string.Empty;
                dataPath = basePath + @"/PDF/";

                //Read the file as stream
                FileStream file = new FileStream(dataPath + "Essential_Pdf.pdf", FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite);

                //Load a PDF document
                PdfLoadedDocument ldoc = new PdfLoadedDocument(file);

                //Create booklet with two sides               
                PdfDocument pdf = PdfBookletCreator.CreateBooklet(ldoc,
                    new SizeF(float.Parse(PageWidth), float.Parse(PageHeight)),
                    (CheckBoxDoubleSide == "DoubleSide") ? true : false);

                //Save the PDF to the MemoryStream
                MemoryStream ms = new MemoryStream();
                pdf.Save(ms);

                //If the position is not set to '0' then the PDF will be empty.
                ms.Position = 0;

                //Close the PDF document.
                pdf.Close(true);
                ldoc.Close(true);

                //Download the PDF document in the browser.
                FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
                fileStreamResult.FileDownloadName = "Booklet.pdf";
                return fileStreamResult;

            }
        }
        catch (Exception ex)
        {
            ViewData["Error"] = ex.ToString();
        }

        return null;
        // return View();
    }
}