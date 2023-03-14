using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public static partial class Program
{
  public static void GoodNightJapanese()
  {
    // 出力ファイル名
    string outputFile = "GoodNightJapanese.pdf";

    // PDFドキュメントを作成する
    PdfDocument pdfDoc = new(new PdfWriter(outputFile));
  
    // フォントをロードする
    string fontFile = "msgothic.ttc,0";
    PdfFont font = PdfFontFactory.CreateFont(fontFile, PdfEncodings.IDENTITY_H);

    // フォントをPDFドキュメントに登録する
    pdfDoc.AddFont(font);

    // ページを追加する
    Document doc = new(pdfDoc);
    doc.SetFont(font);

    List<string> texts = new() { "こんにちは、世界！", "おはようございます", "こんばんは" };
    foreach (string text in texts)
    {
      doc.Add(new Paragraph(text));
    }

    // ドキュメントを閉じる
    doc.Close();
  }
}
