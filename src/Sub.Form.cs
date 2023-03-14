using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Colorspace;

public static partial class Program
{
  public static void Form()
  {
    // PDFファイルのパス
    string inputFile = "input.pdf";
    string outputFile = "output.pdf";

    {
      // PDFドキュメントを作成する
      PdfDocument pdfDoc = new PdfDocument(new PdfWriter(inputFile));

      // フォームフィールドを追加する
      PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
      PdfTextFormField field = PdfFormField.CreateText(pdfDoc, new Rectangle(100, 700, 100, 20), "field_name", "");
      form.AddField(field);

      // フォームフィールドの背景色をなくす
      field.SetBackgroundColor(DeviceRgb.WHITE);

      // ドキュメントを閉じる
      pdfDoc.Close();
    }

    {
      // 作成したPDFドキュメントを開く
      PdfDocument pdfDoc = new PdfDocument(new PdfReader(inputFile), new PdfWriter(outputFile));

      // フォームフィールドに値を設定する
      PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
      PdfFormField field = form.GetField("field_name");
      field.SetValue("new_field_value");

      // ドキュメントを閉じる
      pdfDoc.Close();
    }
  }
}
