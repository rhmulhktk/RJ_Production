using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using System.Drawing.Drawing2D;

namespace RJ_Production
{
    public partial class WaterMark : Form
    {
 

        public WaterMark()
        {
            InitializeComponent();
            this.folderBrowserDialog1.Description = "Select the images directory";

            // Disallow creation of new files using the FolderBrowserDialog.
            this.folderBrowserDialog1.ShowNewFolderButton = false;
        }

        private void WaterMark_Load(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWatermark_Click(object sender, EventArgs e)
        {
            Image logoImg = titleLogo.Image;



            string path = String.Empty;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = folderBrowserDialog1.SelectedPath;
            }

            if (path == String.Empty)
            {
                lblStatus.Text = "Invalid directory..";
                return;
            }


            lblStatus.Text = String.Empty;
            Image img = null;
            string fullPath = String.Empty;

            try
            {
                string[] imgExtension = { "*.jpg", "*.jpeg", ".gif", "*.bmp" };
                List<FileInfo> files = new List<FileInfo>();

                DirectoryInfo dir = new DirectoryInfo(path);

                foreach (string ext in imgExtension)
                {
                    FileInfo[] folder = dir.GetFiles(ext, SearchOption.AllDirectories);
                    foreach (FileInfo file in folder)
                    {
                        FileStream fs = file.OpenRead();
                        fullPath = path + @"\" + file.Name;

                        Stream outputStream = new MemoryStream();
                        //AddWatermark(fs, "RJ PRODUCTION PK","+92349-8882108",logoImg, outputStream);
                        AddWatermark(fs,logoImg, outputStream);
                        fs.Close();
                        file.Delete();
                        img = Image.FromStream(outputStream);

                        using (Bitmap savingImage = new Bitmap(img.Width, img.Height, img.PixelFormat))
                        {
                            using (Graphics g = Graphics.FromImage(savingImage))
                                g.DrawImage(img, new Point(0, 0));
                            savingImage.Save(fullPath, ImageFormat.Jpeg);

                        }

                        img.Dispose();

                    }
                }
                lblStatus.Text = "Processing Completed";
            }
            catch (Exception ex)
            {
                lblStatus.Text = "There was an error during processing..";
            }
            finally
            {
                if (img != null)
                    img.Dispose();
            }
        }


       // public void AddWatermark(FileStream fs, string companyName, string mobileNum, Image logoImg, Stream outputStream)
            public void AddWatermark(FileStream fs, Image logoImg, Stream outputStream)
        {
            Image img = Image.FromStream(fs);
            Font font = new Font("Verdana", 40, FontStyle.Bold, GraphicsUnit.Pixel);
            //Adds a transparent watermark with an 100 alpha value.
            Color color = Color.FromArgb(200, 0, 0, 0);
            //The position where to draw the watermark on the image
            //Point companyNamept = new Point(10, 30);
            //Point mobileNumpt = new Point(40, 70);
            Point logoImgi = new Point(10, 30);
            SolidBrush sbrush = new SolidBrush(color);

            Graphics gr = null;
            try
            {
                gr = Graphics.FromImage(img);
            }
            catch
            {
                // http://support.microsoft.com/Default.aspx?id=814675
                Image img1 = img;
                img = new Bitmap(img.Width, img.Height);
                gr = Graphics.FromImage(img);
                gr.DrawImage(img1, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel);
                img1.Dispose();
            }

            //gr.DrawString(companyName, font, sbrush, companyNamept);
            //gr.DrawString(mobileNum, font, sbrush, mobileNumpt);
           
            gr.DrawImage(logoImg,logoImgi);
            gr.Dispose();

            img.Save(outputStream, ImageFormat.Jpeg);
        }

        private void logoBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Developer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Developer.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.facebook.com/rhmulhktk/");
        }
    }
    }

