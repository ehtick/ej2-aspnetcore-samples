#region Copyright Syncfusion® Inc. 2001-2025.
// Copyright Syncfusion® Inc. 2001-2025. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Pdf.Parsing;

namespace EJ2CoreSampleBrowser.Pages.Pdf;

public class RearrangePages : PageModel
{
    public void OnGet()
    {
        
    }
    private readonly IWebHostEnvironment _hostingEnvironment;
    public RearrangePages(IWebHostEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }
    [HttpPost]
    public ActionResult OnPost(string Browser, string submit1)
    {
        string basePath = _hostingEnvironment.WebRootPath;
        string dataPath = string.Empty;
        dataPath = basePath + @"/PDF/";
        if (submit1 == "View Template")
        {
            Stream file2 = new FileStream(dataPath + "SyncfusionBrochure.pdf", FileMode.Open, FileAccess.Read,
                FileShare.Read);

            //Load the template document
            PdfLoadedDocument loadedDocument = new PdfLoadedDocument(file2);

            //Save the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();

            loadedDocument.Save(ms);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the PDF document.
            loadedDocument.Close(true);

            //Download the PDF document in the browser.
            FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
            fileStreamResult.FileDownloadName = "InputTemplate.pdf";
            return fileStreamResult;
        }
        else
        {
            //Read the file
            FileStream file = new FileStream(dataPath + "SyncfusionBrochure.pdf", FileMode.Open, FileAccess.Read,
                FileShare.ReadWrite);

            //Load the input PDF document
            PdfLoadedDocument ldoc = new PdfLoadedDocument(file);

            //Rearrange the page by index
            ldoc.Pages.ReArrange(new int[] { 2, 0, 1 });

            //Save the PDF to the MemoryStream
            MemoryStream ms = new MemoryStream();

            ldoc.Save(ms);

            //If the position is not set to '0' then the PDF will be empty.
            ms.Position = 0;

            //Close the PDF document.
            ldoc.Close(true);

            //Download the PDF document in the browser.
            FileStreamResult fileStreamResult = new FileStreamResult(ms, "application/pdf");
            fileStreamResult.FileDownloadName = "RearrangedPages.pdf";
            return fileStreamResult;

        }
    }
}