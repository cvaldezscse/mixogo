﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IronPdf;
using Mixogo.ClassesLibraries.Models;

namespace Mixogo.ClassesLibraries.Helpers
{
    /// <summary>
    /// Class used to build a PDF file from its structure
    /// </summary>
    public class PDFReportHelper
    {
        HtmlToPdf Renderer;

        public PDFReportHelper()
        {

        }

        public void ConfigureDocument()
        {
            Renderer = new HtmlToPdf();
            var pdf = Renderer.RenderHtmlAsPdf("<H1>Hello IronPDF</H1><p>This is only a test<p>");
            pdf.SaveAs(@"C:\Users\CBQA-0090\autogenerated\new_file.pdf");
        }


        public void ReplaceValuesInTheBaseTemplate(Invoice invoice)
        {

        }
    }
}
