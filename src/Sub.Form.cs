using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas;
using iText.Layout;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.Layout.Properties;
using iText.Layout.Renderer;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using iText.IO.Font.Constants;
using System.Text.RegularExpressions;
using iText.Forms;
using iText.Forms.Fields;

public static partial class Program
{
  public static void Form()
  {
    // PDFファイルのパス
    string inputFile = "input.pdf";
    string outputFile = "output.pdf";

    // PDFドキュメントを作成する
    PdfDocument pdfDoc = new PdfDocument(new PdfWriter(inputFile));

    // ページを追加する
    PdfPage page = pdfDoc.AddNewPage();
    PdfCanvas canvas = new PdfCanvas(page);

    // フォームフィールドを追加する
    PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
    PdfTextFormField field = PdfFormField.CreateText(pdfDoc, new Rectangle(100, 700, 100, 20), "field_name", "");
    form.AddField(field);

    // ドキュメントを閉じる
    pdfDoc.Close();

    // 作成したPDFドキュメントを開く
    PdfDocument pdfDoc2 = new PdfDocument(new PdfReader(inputFile), new PdfWriter(outputFile));

    // フォームフィールドに値を設定する
    PdfAcroForm form2 = PdfAcroForm.GetAcroForm(pdfDoc2, true);
    PdfFormField field2 = form2.GetField("field_name");
    field2.SetValue("field_value");

    // ドキュメントを閉じる
    pdfDoc2.Close();
  }
}
