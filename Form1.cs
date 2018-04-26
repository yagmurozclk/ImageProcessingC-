using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing2
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        

       public Operator processing;
        public Form1()
        {
            InitializeComponent();
            processing = new Operator();

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPEG Files| *.jpg; *.png | All Files(*.*) | *.*";
            dialog.InitialDirectory = ".";
            dialog.Title = "Please select image folder";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                //this.pictureBox1.Image = new Bitmap(dialog.FileName);
                this.pictureBox1.Size = new System.Drawing.Size(302, 231);

                //this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                // this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;

                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxRed.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxGreen.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxBlue.SizeMode = PictureBoxSizeMode.StretchImage;



                //this.pictureBox1.Image = new Bitmap(dialog.FileName);
                this.pictureBox2.Size = new System.Drawing.Size(302 , 231);
                this.pictureBoxRed.Size = new System.Drawing.Size(302, 231);
                this.pictureBoxGreen.Size = new System.Drawing.Size(302, 231);
                this.pictureBoxBlue.Size = new System.Drawing.Size(302, 231);


                //this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                //this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;

            

            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG Files| *.jpg; *.png | All Files(*.*) | *.*";
            if (DialogResult.OK == sfd.ShowDialog())
            {
                pictureBox2.Image.Save(sfd.FileName);

            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void negativeinvertToolStripMenuItem_Click(object sender, EventArgs e)
        {



            /*  if (f2 == null)
              {
                  f2 = new FormNegInv();
                  f2.MdiParent = this;
                  //f2.FormClosed += new FormClosedEventHandler(f2_FormClosed);

                  f2.Show();

              }
              else
                  f2.Activate();*/


            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();//renk matrisi kullanarak görüntü renklerini ayarlar
            ColorMatrix cmPicture = new ColorMatrix(new float[][]//5x5 lik matris tanımlar
            {
                new float[] {-1, 0, 0, 0, 0},//red
                new float[] {0, -1, 0, 0, 0},//green
                new float[] {0, 0, -1, 0, 0},//blue
                new float[] {0, 0, 0,  1, 0},//alpha
                new float[] {1, 1, 1, 0,  1},//combination


            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox2.Image = bmp;
      
           
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Bitmap bmp = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                new float[] {0.299f,0.299f,0.299f,0,0},
                new float[] {0.587f, 0.587f, 0.587f, 0,0},
                new float[] {0.299f,0.299f,0.299f,0,0},
                new float[] {0.114f, 0.114f, 0.114f, 0,0},
                new float[] {0,0,0,1,0},
                new float[] {0,0,0,0,0},


            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            pictureBox2.Image = bmp;



/*
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }

    */
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color c = bmp.GetPixel(e.X, e.Y);
                pictureBox3.BackColor = c;

                labelRValue.Text = c.R.ToString();
                labelGValue.Text = c.G.ToString();
                labelBValue.Text = c.B.ToString();
                labelAvalue.Text = c.A.ToString();


            }catch(Exception ex)
            {

            }
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                Bitmap bmp = new Bitmap(pictureBox1.Image);
                Color c = bmp.GetPixel(e.X, e.Y);
                pictureBox3.BackColor = c;

                labelRValue.Text = c.R.ToString();
                labelGValue.Text = c.G.ToString();
                labelBValue.Text = c.B.ToString();
                labelAvalue.Text = c.A.ToString();


            }
            catch (Exception ex)
            {

            }

        }

     
      //  private Operator processing;


        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            //this.processing.calcHisto(this);
           // this.pictureBox1.Image = this.processing.getImage();

            ////this.menuItem5.Enabled = true;

            //this.Invalidate();
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Image img2 = pictureBox2.Image;


            Bitmap bmp = new Bitmap(img);
            int width = bmp.Width;
            int height = bmp.Height;

            //byte[] r = new byte[width * height];
            //byte[] g = new byte[width * height];
            //byte[] b = new byte[width * height];
           
            ImageAttributes ia = new ImageAttributes();//renk matrisi kullanarak görüntü renklerini ayarlar
            ColorMatrix cmPicture = new ColorMatrix(new float[][]//5x5 lik matris tanımlar
            {
                new float[] {1, 0, 0, 0, 0},//red
                new float[] {0,-1, 0, 0, 0},//green
                new float[] {0, 0,-1, 0, 0},//blue
                new float[] {0, 0, 0, 1, 0},//alpha
                new float[] {0, 0, 0, 0, 0},//combination


            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();

            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap abmp = new Bitmap(bmp);
            for(int y = 0; y < height; y++)
            {
                for(int x=0; x < width; x++)
                {
                    Color c = bmp.GetPixel(x,y);
                    int a = c.A;
                    int r = c.R;
                    //int g = c.G;
                   // int b = c.B;


                    rbmp.SetPixel(x, y, Color.FromArgb(255, r, 0, 0));
                   // gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                   // bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));


                    pictureBoxRed.Image = rbmp;
                    pictureBox2.Image = rbmp;
                  

                }
            }
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Image img = pictureBox1.Image;
            Image img2 = pictureBox2.Image;


            Bitmap bmp = new Bitmap(img);
            int width = bmp.Width;
            int height = bmp.Height;

            //byte[] r = new byte[width * height];
           //byte[] g = new byte[width * height];
            //byte[] b = new byte[width * height];

            ImageAttributes ia = new ImageAttributes();//renk matrisi kullanarak görüntü renklerini ayarlar
            ColorMatrix cmPicture = new ColorMatrix(new float[][]//5x5 lik matris tanımlar
            {
                new float[] {-1, 0, 0, 0, 0},//red
                new float[] {0,1, 0, 0, 0},//green
                new float[] {0, 0,-1, 0, 0},//blue
                new float[] {0, 0, 0, 1, 0},//alpha
                new float[] {0, 0, 0, 0, 0},//combination


            });
            ia.SetColorMatrix(cmPicture);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            gr.Dispose();

            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap abmp = new Bitmap(bmp);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x <width; x++)
                {
                    //pixel(x, y);
                    Color c =bmp.GetPixel(x, y);
                    int a = c.A;
                   // int r = c.R;
                    int g = c.G;
                    //int b = c.B;
                    //int r = c[0];
                    //int g = c[1];
                    //int b = color[2];

                    //pixel Gpl = new pixel(0, g, 0);






                   // rbmp.SetPixel(x, y, Color.FromArgb(a, r, 0, 0));
                    gbmp.SetPixel(x, y, Color.FromArgb(a, 0, g, 0));
                   // bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));


                    // pictureBoxRed.Image = rbmp;
                    pictureBoxGreen.Image = gbmp;
                    pictureBox2.Image = gbmp;

                }
            }
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            Image img1 = pictureBox2.Image;

            Bitmap bmp = new Bitmap(img);
            int width = bmp.Width;
            int height = bmp.Height;

            //byte[] r = new byte[width * height];
            //byte[] g = new byte[width * height];
            //byte[] b = new byte[width * height];

            ImageAttributes ia = new ImageAttributes();//renk matrisi kullanarak görüntü renklerini ayarlar
            ColorMatrix cmPicture = new ColorMatrix(new float[][]//5x5 lik matris tanımlar
            {
                new float[] {-1, 0, 0, 0, 0},//red
                new float[] {0,-1, 0, 0, 0},//green
                new float[] {0, 0,1, 0, 0},//blue
                new float[] {0, 0, 0, 1, 0},//alpha
                new float[] {0, 0, 0, 0, 0},//combination


            });
            ia.SetColorMatrix(cmPicture);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);
            g.Dispose();
            Bitmap rbmp = new Bitmap(bmp);
            Bitmap gbmp = new Bitmap(bmp);
            Bitmap bbmp = new Bitmap(bmp);
            Bitmap abmp = new Bitmap(bmp);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x <width; x++)
                {
                    Color c = bmp.GetPixel(x, y);
                    int a = c.A;
                    int b = c.B;


                    bbmp.SetPixel(x, y, Color.FromArgb(a, 0, 0, b));


                   // pictureBoxRed.Image = rbmp;
                    // pictureBoxGreen.Image = gbmp;
                     pictureBoxBlue.Image = bbmp;
                    pictureBox2.Image = bbmp;

                }
            }
        }
    }

    internal class pixel
    {
        private int r;
        private int v1;
        private int v2;

        public pixel(int r, int v1, int v2)
        {
            this.r = r;
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
    
