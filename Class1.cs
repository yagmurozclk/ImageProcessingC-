using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessing2
{
    public class Operator
    {
        private Bitmap bmpimg;
        public Operator()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public void setImage(Bitmap bmp)
        {
            bmpimg = (Bitmap)bmp.Clone();
        }

        public Bitmap getImage()
        {
            return (Bitmap)bmpimg.Clone();
        }

        public void calcHisto(Form1 form)
        {
            BitmapData data = bmpimg.LockBits(new Rectangle(0, 0, bmpimg.Width, bmpimg.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* ptr = (byte*)data.Scan0;

                int remain = data.Stride - data.Width * 3;

                int[] histogram = new int[256];
                for (int i = 0; i < histogram.Length; i++)
                    histogram[i] = 0;

                for (int i = 0; i < data.Height; i++)
                {
                    for (int j = 0; j < data.Width; j++)
                    {
                        int mean = ptr[0] + ptr[1] + ptr[2];
                        mean /= 3;

                        histogram[mean]++;
                        ptr += 3;
                    }

                    ptr += remain;
                }
                drawHistogram(histogram, form);

            }

            bmpimg.UnlockBits(data);
        }


        public void drawHistogram(int[] histogram, Form1 form)
        {

            Bitmap bmp = new Bitmap(histogram.Length + 10, 310);


            int keep = 0;

            BitmapData data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            unsafe
            {
                int remain = data.Stride - data.Width * 3;
                byte* ptr = (byte*)data.Scan0;

                for (int i = 0; i < data.Height; i++)
                {

                    for (int j = 0; j < data.Width; j++)
                    {
                        ptr[0] = ptr[1] = ptr[2] = 150;
                        ptr += 3;
                    }
                    ptr += remain;

                }

                int max = 0;
                for (int i = 0; i < histogram.Length; i++)
                {

                    if (max < histogram[i])
                        max = histogram[i];

                }

                for (int i = 0; i < histogram.Length; i++)
                {
                    ptr = (byte*)data.Scan0;
                    ptr += data.Stride * (305) + (i + 5) * 3;

                    int length = (int)(1.0 * histogram[i] * 300 / max);

                    for (int j = 0; j < length; j++)
                    {
                        ptr[0] = 255;
                        ptr[1] = ptr[2] = 0;
                        ptr -= data.Stride;
                    }

                }

            }

            bmp.UnlockBits(data);
        }

    }
}


