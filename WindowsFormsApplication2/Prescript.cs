using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Imaging;
using System.Diagnostics;


namespace WindowsFormsApplication2
{
    public partial class Prescript : Form
    {
        ScreenCapture capScreen = new ScreenCapture();
        public Prescript()
        {
            InitializeComponent();

            button1.Visible = false;
            button2.Visible = false;
        }
        public void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave
                (@"C:\Users\Public\Documents\test.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            captureScreen();
            string date = label2.Text;
            string name = label5.Text;
            // Create new pdf document and page
            PdfDocument doc = new PdfDocument();
            PdfPage oPage = new PdfPage();

            // Add the page to the pdf document and add the captured image to it
            doc.Pages.Add(oPage);
            XGraphics xgr = XGraphics.FromPdfPage(oPage);
            XImage img = XImage.FromFile(@"C:\Users\Public\Documents\test.png");
            xgr.DrawImage(img, 0, 0);

            if (System.IO.Directory.Exists(@"C:\Users\Public\Documents\Appointments"))
            {
                doc.Save(@"C:\Users\Public\Documents\Prescripts\Prescript '" + date + "'" + name + ".pdf");
            }
            else
            {
                MessageBox.Show("File not found");
            }
            

            doc.Close();


            // I used the Dispose() function to be able to 
            // save the same form again, in case some values have changed.
            // When I didn't use the function, a GDI+ error occurred.
            img.Dispose();
            timer1.Stop();

            button1.Visible = true;
            button2.Visible = true;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string date = label2.Text;
            string name = label5.Text;
            Process.Start(@"C:\Users\Public\Documents\Prescripts\Prescript '" + date + "'" + name + ".pdf");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }
    }
}
