using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Forms;
using iText.Forms.Fields;
using iText.Kernel.Colors;

public static partial class Program
{
  public static void Replace()
  {
    // PDFファイルのパス
    string inputFile = "replace.pdf";
    string outputFile = "replaced.pdf";

    {
      // PDFドキュメントを作成する
      PdfDocument pdfDoc = new PdfDocument(new PdfWriter(inputFile));

      // フォームフィールドを追加する
      PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
      PdfTextFormField field = PdfFormField.CreateText(pdfDoc, new Rectangle(100, 700, 100, 20), "field1", "");
      form.AddField(field);

      // フォームフィールドの背景色をなくす
      field.SetBackgroundColor(DeviceRgb.WHITE);

      // ドキュメントを閉じる
      pdfDoc.Close();
    }

    {
      // PDFファイルを読み込む
      PdfDocument pdfDoc = new PdfDocument(new PdfReader(inputFile), new PdfWriter(outputFile));

      // フォームフィールドに値を設定する
      PdfAcroForm form = PdfAcroForm.GetAcroForm(pdfDoc, true);
      PdfFormField field = form.GetField("field1");
      if (field != null)
      {
        ((PdfTextFormField)field).SetValue("replaced");
      }
      else
      {
        Console.WriteLine("フォームフィールドが見つかりませんでした。");
      }

      // フォームをテキストに変換する
      PdfAcroForm.GetAcroForm(pdfDoc, true).FlattenFields();

      // PDFファイルを閉じる
      pdfDoc.Close();
    }
  }
}
