using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

public static partial class Program
{
  public static void Size()
  {
    // A4サイズのページを作成
    PageSize pageSizeA4 = PageSize.A4;
    PdfDocument pdfDocA4 = new(new PdfWriter("SizeA4.pdf"));
    pdfDocA4.SetDefaultPageSize(pageSizeA4);
    Document docA4 = new(pdfDocA4);

    // A5サイズのページを作成
    PageSize pageSizeA5 = PageSize.A5;
    PdfDocument pdfDocA5 = new(new PdfWriter("SizeA5.pdf"));
    pdfDocA5.SetDefaultPageSize(pageSizeA5);
    Document docA5 = new(pdfDocA5);

    // B4サイズのページを作成
    PageSize pageSizeB4 = PageSize.B4;
    PdfDocument pdfDocB4 = new(new PdfWriter("SizeB4.pdf"));
    pdfDocB4.SetDefaultPageSize(pageSizeB4);
    Document docB4 = new(pdfDocB4);

    // B5サイズのページを作成
    PageSize pageSizeB5 = PageSize.B5;
    PdfDocument pdfDocB5 = new(new PdfWriter("SizeB5.pdf"));
    pdfDocB5.SetDefaultPageSize(pageSizeB5);
    Document docB5 = new(pdfDocB5);

    // 文書をクローズ
    docA4.Close();
    docA5.Close();
    docB4.Close();
    docB5.Close();
  }
}
