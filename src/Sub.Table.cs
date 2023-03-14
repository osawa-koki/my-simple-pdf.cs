using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public static partial class Program
{
  public static void Table()
  {
    // 新しいPDF文書を作成
    PdfDocument pdfDoc = new(new PdfWriter("Table.pdf"));

    // ページを作成
    Document doc = new(pdfDoc);

    // テーブルを作成
    Table table = new(new float[] { 1, 2, 3 }); // 列の幅を設定

    // テーブルヘッダを作成
    Cell header1 = new Cell().Add(new Paragraph("Header 1"));
    Cell header2 = new Cell().Add(new Paragraph("Header 2"));
    Cell header3 = new Cell().Add(new Paragraph("Header 3"));
    table.AddHeaderCell(header1);
    table.AddHeaderCell(header2);
    table.AddHeaderCell(header3);

    // テーブルデータを作成
    Cell cell1 = new Cell().Add(new Paragraph("1"));
    Cell cell2 = new Cell().Add(new Paragraph("2"));
    Cell cell3 = new Cell().Add(new Paragraph("3"));
    table.AddCell(cell1);
    table.AddCell(cell2);
    table.AddCell(cell3);

    Cell cell4 = new Cell().Add(new Paragraph("4"));
    Cell cell5 = new Cell().Add(new Paragraph("5"));
    Cell cell6 = new Cell().Add(new Paragraph("6"));
    table.AddCell(cell4);
    table.AddCell(cell5);
    table.AddCell(cell6);

    // テーブルを文書に追加
    doc.Add(table);

    // 文書をクローズ
    doc.Close();
  }
}
