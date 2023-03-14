using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

class Program
{
  static void Main(string[] args)
  {
    // 新しいPDF文書を作成
    PdfDocument pdfDoc = new(new PdfWriter("HelloWorld.pdf"));

    // ページを作成
    Document doc = new(pdfDoc);

    // テキストを追加
    Paragraph para = new("Hello, World!");
    doc.Add(para);

    // 文書をクローズ
    doc.Close();
  }
}
