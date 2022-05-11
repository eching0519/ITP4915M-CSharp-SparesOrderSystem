using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using SLMC_MS.model;

namespace SLMC_MS.model
{
    class Invoice
    {
        int invID;
        DateTime invDate;
        int orderID;
        DateTime orderDate;
        double invAmt;
        String invName;
        String invAddress;
        String dealerID;
        String dealerName;
        List<orderitem> items;

        public Invoice(int invoiceID)
        {
            try
            {
                using (slmc db = new slmc())
                {
                    invoice inv = db.invoice.FirstOrDefault(i => i.invID == invoiceID);
                    order order = db.order.FirstOrDefault(i => i.orderID == inv.orderID);
                    staff dealer = db.staff.FirstOrDefault(i => i.staffID.Equals(order.dealerID));

                    invID = invoiceID;
                    orderID = order.orderID;
                    orderDate = order.orderDate;
                    invDate = inv.invDate;
                    //invAmt = inv.invAmt;
                    invName = order.invName;
                    invAddress = order.invAddress;
                    dealerID = dealer.staffID;
                    dealerName = dealer.name;
                    items = order.orderitem.ToList();
                    invAmt = items.Select(i => i.subTotal).Sum();
                }
            } catch (Exception exp)
            {

            }
        }

        public Invoice(order order)
        {
            try
            {
                using (slmc db = new slmc())
                {
                    invoice inv = db.invoice.FirstOrDefault(i => i.orderID == order.orderID);
                    staff dealer = db.staff.FirstOrDefault(i => i.staffID.Equals(order.dealerID));

                    invID = inv.invID;
                    orderID = order.orderID;
                    orderDate = order.orderDate;
                    invDate = inv.invDate;
                    //invAmt = inv.invAmt;
                    invName = order.invName;
                    invAddress = order.invAddress;
                    dealerID = dealer.staffID;
                    dealerName = dealer.name;
                    items = db.orderitem.Where(i => i.orderID == order.orderID).ToList();
                    invAmt = items.Select(i => i.subTotal).Sum();
                }
            }
            catch (Exception exp)
            {

            }
        }

        public void exportPDF()
        {
            string downloadsPath = Environment.GetEnvironmentVariable("USERPROFILE")+@"\"+"Downloads";
            Document doc = new Document(iTextSharp.text.PageSize.A4, 50, 20, 50, 20);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(downloadsPath+"\\Invoice" +invID+".pdf", FileMode.Create));
            doc.Open();

            doc.AddTitle("Invoice " + invID);
            iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 24);
            iTextSharp.text.Font textFont = FontFactory.GetFont("Arial", 14);

            Paragraph paragraph = new Paragraph();
            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance("Logo_Land.png");
            logo.ScalePercent(25f);
            logo.Alignment = Element.ALIGN_CENTER;
            paragraph.Add(logo);
            paragraph.Add("\n");
            paragraph.Add(new Phrase("Invoice", titleFont));

            paragraph.Alignment = Element.ALIGN_CENTER;

            iTextSharp.text.Font basicHeader = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.BLACK);

            PdfPTable basicTable = new PdfPTable(4);
            PdfPCell cell = new PdfPCell(new Phrase("Invoice ID", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(invID+""));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Invoice Date", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(invDate.ToShortDateString()));
            cell.Border = 0;
            basicTable.AddCell(cell);

            //
            cell = new PdfPCell(new Phrase("Order ID", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(orderID + ""));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Order Date", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(orderDate.ToShortDateString()));
            cell.Border = 0;
            basicTable.AddCell(cell);

            //
            cell = new PdfPCell(new Phrase("Dealer ID", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(dealerID));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Dealer Name", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(dealerName));
            cell.Border = 0;
            basicTable.AddCell(cell);
            //

            cell = new PdfPCell(new Phrase("Invoice Name", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(invName));
            cell.Colspan = 3;
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Invoice Address", basicHeader));
            cell.Border = 0;
            basicTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(invAddress));
            cell.Colspan = 3;
            cell.Border = 0;
            basicTable.AddCell(cell);

            basicTable.SpacingAfter = 10f;
            paragraph.Add(basicTable);
            //////////////////////////////////////////////////////////////
            iTextSharp.text.Font tableHeader = FontFactory.GetFont("Arial", 12, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
            PdfPTable itemTable = new PdfPTable(new float[] { 1f, 2, 0.7f, 1f });

            cell = new PdfPCell(new Phrase("Item ID", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Item Name", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("QTY", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cell);

            cell = new PdfPCell(new Phrase("Subtotal(¥)", tableHeader));
            cell.BackgroundColor = BaseColor.BLACK;
            cell.HorizontalAlignment = Element.ALIGN_CENTER;
            itemTable.AddCell(cell);

            foreach (orderitem item in items)
            {
                item i = Items.GetItem(item.itemID);
                cell = new PdfPCell(new Phrase(item.itemID));
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.BorderColor = BaseColor.WHITE;
                itemTable.AddCell(cell);
                cell = new PdfPCell(new Phrase(i.name));
                cell.BorderColor = BaseColor.WHITE;
                itemTable.AddCell(cell);
                cell = new PdfPCell(new Phrase(item.qty+""));
                cell.BorderColor = BaseColor.WHITE;
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                itemTable.AddCell(cell);
                cell = new PdfPCell(new Phrase(item.subTotal+""));
                cell.BorderColor = BaseColor.WHITE;
                cell.HorizontalAlignment = Element.ALIGN_RIGHT;
                itemTable.AddCell(cell);
            }

            iTextSharp.text.Font totalStyle = FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            cell = new PdfPCell(new Phrase("Total(¥)", totalStyle));
            cell.Colspan = 3;
            cell.BorderColor = BaseColor.WHITE;
            cell.PaddingTop = 7f;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            itemTable.AddCell(cell);

            cell = new PdfPCell(new Phrase(invAmt + "", totalStyle));
            cell.BorderColor = BaseColor.WHITE;
            cell.PaddingTop = 7f;
            cell.HorizontalAlignment = Element.ALIGN_RIGHT;
            itemTable.AddCell(cell);

            paragraph.Add(itemTable);
            paragraph.Add("\n\n\n");
            paragraph.Add("Received in good order\n\n");
            paragraph.Add("Date .............................  Signature .............................");
            doc.Add(paragraph);

            doc.Close();

            // open pdf
            System.Diagnostics.Process.Start(downloadsPath + "\\Invoice" + invID + ".pdf");
        }
    }
}
