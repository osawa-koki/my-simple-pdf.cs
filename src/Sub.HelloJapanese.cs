using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public static partial class Program
{
  public static void HelloJapanese()
  {
    // 出力ファイル名
    string outputFile = "HelloJapanese.pdf";

    // PDFドキュメントを作成する
    PdfDocument pdfDoc = new(new PdfWriter(outputFile));

    string fontPath = @"msgothic.ttc,0"; // MS Gothicフォントファイルのパス
    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

    // ページを追加する
    Document doc = new(pdfDoc);
    doc.Add(new Paragraph("こんにちは、世界！").SetFont(font));

    // ドキュメントを閉じる
    doc.Close();
  }
}
