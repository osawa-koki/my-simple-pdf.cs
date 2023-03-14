using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public static partial class Program
{
  public static void Image()
  {
    // 新しいPDF文書を作成
    PdfDocument pdfDoc = new PdfDocument(new PdfWriter("Image.pdf"));

    // ページを作成
    Document doc = new Document(pdfDoc);

    // 画像を読み込む
    ImageData imageData = ImageDataFactory.Create("tako.png");
    Image image = new Image(imageData);

    // 画像を追加
    doc.Add(image);

    // 文書をクローズ
    doc.Close();
  }
}
