using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

public static partial class Program
{
  public static void ComplexTable()
  {
    // 新しいPDF文書を作成
    PdfDocument pdfDoc = new(new PdfWriter("ComplexTable.pdf"));

    // ページを作成
    Document doc = new(pdfDoc);

    // テーブルを作成
    Table table = new Table(new UnitValue[] { UnitValue.CreatePercentValue(20), UnitValue.CreatePercentValue(20), UnitValue.CreatePercentValue(20), UnitValue.CreatePercentValue(20), UnitValue.CreatePercentValue(20) })
        .UseAllAvailableWidth();

    // ヘッダー行を作成
    Cell header1 = new Cell(1, 2).Add(new Paragraph("Header 1&2"));
    Cell header3 = new Cell().Add(new Paragraph("Header 3"));
    Cell header4 = new Cell().Add(new Paragraph("Header 4"));
    Cell header5 = new Cell().Add(new Paragraph("Header 5"));
    Cell header6 = new Cell().Add(new Paragraph("Header 6"));
    table.AddHeaderCell(header1);
    table.AddHeaderCell(header3);
    table.AddHeaderCell(header4);
    table.AddHeaderCell(header5);
    table.AddHeaderCell(header6);

    // サブヘッダー行を作成
    Cell subHeader1 = new Cell().Add(new Paragraph("Subheader 1"));
    Cell subHeader2 = new Cell().Add(new Paragraph("Subheader 2"));
    Cell subHeader3 = new Cell().Add(new Paragraph("Subheader 3"));
    Cell subHeader4 = new Cell().Add(new Paragraph("Subheader 4"));
    Cell subHeader5 = new Cell().Add(new Paragraph("Subheader 5"));
    table.AddHeaderCell(subHeader1);
    table.AddHeaderCell(subHeader2);
    table.AddHeaderCell(subHeader3);
    table.AddHeaderCell(subHeader4);
    table.AddHeaderCell(subHeader5);

    // テーブルデータを作成
    Cell cell1 = new Cell().Add(new Paragraph("1"));
    Cell cell2 = new Cell().Add(new Paragraph("2"));
    Cell cell3 = new Cell().Add(new Paragraph("3"));
    Cell cell4 = new Cell().Add(new Paragraph("4"));
    Cell cell5 = new Cell().Add(new Paragraph("5"));
    table.AddCell(cell1);
    table.AddCell(cell2);
    table.AddCell(cell3);
    table.AddCell(cell4);
    table.AddCell(cell5);

    Cell cell6 = new Cell().Add(new Paragraph("6"));
    Cell cell7 = new Cell().Add(new Paragraph("7"));
    Cell cell8 = new Cell().Add(new Paragraph("8"));
    Cell cell9 = new Cell().Add(new Paragraph("9"));
    Cell cell10 = new Cell().Add(new Paragraph("10"));
    table.AddCell(cell6);
    table.AddCell(cell7);
    table.AddCell(cell8);
    table.AddCell(cell9);
    table.AddCell(cell10);

    // テーブルを文書に追加
    doc.Add(table);

    // 文書をクローズ
    doc.Close();
  }
}
