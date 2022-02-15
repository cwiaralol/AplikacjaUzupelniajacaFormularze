using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;



namespace AplikacjaUzupelniajacaFormularze
{
    static class Program
    {
        internal static bool d1;
        internal static bool d2;
        internal static bool d3;

        internal static string imie;
        internal static string nazwisko;
        internal static string datax;
        internal static string miejscowosc;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());



            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);



            if (d1 == true)
            {

                PdfDocument pd = PdfReader.Open(@"Dokumenty\mzgk nowe editedpdf.pdf", PdfDocumentOpenMode.Modify);


                int i = 0;
                foreach (var r in pd.AcroForm.Fields)
                {
                    if (pd.AcroForm.Fields[i].Name == "Imie")
                    {
                        pd.AcroForm.Fields[i].Value = new PdfString(imie);
                    }

                    if (pd.AcroForm.Fields[i].Name == "Nazwisko")
                    {
                        pd.AcroForm.Fields[i].Value = new PdfString(nazwisko);
                    }

                    if (pd.AcroForm.Fields[i].Name == "Data")
                    {

                        pd.AcroForm.Fields[i].Value = new PdfString(datax);

                    }

                    if (pd.AcroForm.Fields[i].Name == "Miejscowosc")
                    {

                        pd.AcroForm.Fields[i].Value = new PdfString(miejscowosc);

                    }

                    i++;

                }


                



                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filename = path + "\\WNIOSEK O PRZY��CZENIE NIERUCHOMO�CI DO SIECI WODOCI�GOWEJ I LUB KANALIZACYJNEJ.pdf";




                pd.Save(filename);

                d1 = false;
            }

            if (d2 == true)
                {

                    PdfDocument pd = PdfReader.Open(@"Dokumenty\enea rodoedited.pdf", PdfDocumentOpenMode.Modify);


                    int i = 0;
                    foreach (var r in pd.AcroForm.Fields)
                    {
                        if (pd.AcroForm.Fields[i].Name == "Imie")
                        {
                            pd.AcroForm.Fields[i].Value = new PdfString(imie);
                        }

                        if (pd.AcroForm.Fields[i].Name == "Nazwisko")
                        {
                            pd.AcroForm.Fields[i].Value = new PdfString(nazwisko);
                        }

                        if (pd.AcroForm.Fields[i].Name == "Data")
                        {

                            pd.AcroForm.Fields[i].Value = new PdfString(datax);

                        }

                    if (pd.AcroForm.Fields[i].Name == "Miejscowosc")
                    {

                        pd.AcroForm.Fields[i].Value = new PdfString(miejscowosc);

                    }

                    i++;

                    }


                /*
                if (pd.AcroForm.Elements.ContainsKey("/NeedAppearances"))
                {
                    pd.AcroForm.Elements["/ NeedAppearances"] = new PdfBoolean(true);
                }
                else
                {
                    pd.AcroForm.Elements.Add("/NeedAppearances", new PdfBoolean(true));
                }

                */

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filename = path + "\\Wniosek o okre�lenie warunk�w przy��czenia dla podmiot�w ubiegaj�cych si� o przy��czenie z moc� przy��czeniow� nie wi�ksz� ni� 40kW.pdf";


                pd.Save(filename);

                d2 = false;
            }


            if (d3 == true)
            {
                PdfDocument pd = PdfReader.Open(@"Dokumenty\oswiadczenie.pdf", PdfDocumentOpenMode.Modify);
          
                int i = 0;
                foreach (var r in pd.AcroForm.Fields)
                {
                    if (pd.AcroForm.Fields[i].Name == "Imie")
                    {
                        pd.AcroForm.Fields[i].Value = new PdfString(imie);
                    }

                    if (pd.AcroForm.Fields[i].Name == "Nazwisko")
                    {
                        pd.AcroForm.Fields[i].Value = new PdfString(nazwisko);
                    }

                    if (pd.AcroForm.Fields[i].Name == "Data")
                    {

                        pd.AcroForm.Fields[i].Value = new PdfString(datax);

                    }

                    if (pd.AcroForm.Fields[i].Name == "Miejscowosc")
                    {

                        pd.AcroForm.Fields[i].Value = new PdfString(miejscowosc);

                    }

                    i++;

                }


                /*
                if (pd.AcroForm.Elements.ContainsKey("/NeedAppearances"))
                {
                    pd.AcroForm.Elements["/ NeedAppearances"] = new PdfBoolean(true);
                }
                else
                {
                    pd.AcroForm.Elements.Add("/NeedAppearances", new PdfBoolean(true));
                }

                */



                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string filename = path + "\\O�WIADCZENIE O POSIADANYM PRAWIE DO DYSPONOWANIA NIERUCHOMO�CI� NA CELE BUDOWLANE(B-3).pdf";


                pd.Save(filename);

                d3 = false;
            }






        }
    }
}
