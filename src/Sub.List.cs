using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public static partial class Program
{
  public static void List()
  {
    // PDF文書を作成
    PdfDocument pdfDoc = new(new PdfWriter("list.pdf"));

    // リストを作成
    List list = new();
    list.Add(new ListItem("Item 1"));
    list.Add(new ListItem("Item 2"));
    list.Add(new ListItem("Item 3"));
    
    // リストをドキュメントに追加
    Document doc = new(pdfDoc);
    doc.Add(list);

    // ドキュメントをクローズ
    doc.Close();
  }
}
