using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using iText;
using iText.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace DnD_CharacterBuilder_Library
{
    public class CreatPDF
    {
        
        public static void PDF()
        {
            PdfReader reader = new PdfReader("Character_Sheet.pdf");
            reader.SetUnethicalReading(true);
            PdfWriter writer = new PdfWriter("Outputfile.pdf");
            PdfDocument pdfDoc = new PdfDocument(reader, writer);


            pdfDoc.Close();

        }
 
    }
}
