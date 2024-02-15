using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace JuliaSetC_
{
    public partial class Form1 : Form
    {
        //[DllImport("C:\\Users\\kanal\\source\\repos\\JuliaSetJA\\x64\\Debug\\JuliaSetAsm.dll", CallingConvention = CallingConvention.Cdecl)]
        //public static extern void MyProc1(int width, int height, int[] output);

        [DllImport("C:\\Users\\kanal\\source\\repos\\JuliaSetJA\\x64\\Debug\\JuliaSetAsm.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void julia(int[] output, double realPart, double imgPart, int maxIter);


        [DllImport("C:\\Users\\kanal\\source\\repos\\JuliaSetJA\\x64\\Debug\\JuliaSetCPP.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern void GenerateJuliaSet(int width, int height, int maxIter, double realPart, double imgPart, float zoom, int[] output);

        private Bitmap fractalBitmap;
        public Form1()
        {
            InitializeComponent();
            fractalBitmap = new Bitmap(ObrazPictureBox.Width, ObrazPictureBox.Height);

            zoomInButton.Click += ZoomInButton_Click;
            zoomOutButton.Click += ZoomOutButton_Click;

            ObrazPictureBox.MouseDown += ObrazPictureBox_MouseDown;
            ObrazPictureBox.MouseUp += ObrazPictureBox_MouseUp;
            ObrazPictureBox.MouseMove += ObrazPictureBox_MouseMove;
            ObrazPictureBox.Paint += ObrazPictureBox_Paint;

            WyborcomboBox.SelectedIndex = 0;
            KolorycomboBox.SelectedIndex = 0;
        }

        private void GenerateAndDisplayFractal()
        {
            int width = ObrazPictureBox.Width;
            int height = ObrazPictureBox.Height;
            int maxIter = (int)IteracjienumericUpDown.Value; // Maksymalna liczba iteracji
            double realPart = (double)wspXnumericUpDown.Value; // Część rzeczywista liczby zespolonej
            double imgPart = (double)wspYnumericUpDown.Value; // Część urojona liczby zespolonej

            int[] output = new int[width * height]; // Tablica na wyniki

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            string selectedLibrary = WyborcomboBox.SelectedItem.ToString();
            if (selectedLibrary == "ASM")
            {
                julia(output, realPart, imgPart, maxIter);
            }
            else if (selectedLibrary == "C++")
            {
                GenerateJuliaSet(width, height, maxIter, realPart, imgPart, zoom, output);
            }

            stopwatch.Stop();

            // Wyświetlanie czasu wykonania
            if (selectedLibrary == "ASM")
            {
                czasASMLabel.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
            }
            else if (selectedLibrary == "C++")
            {
                czasCPPLabel.Text = stopwatch.Elapsed.TotalMilliseconds.ToString() + " ms";
            }

            // Przetwarzanie wyników i rysowanie fraktala
            Bitmap fractalBitmap = new Bitmap(width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int iter = output[y * width + x];

                    if (iter < maxIter)
                    {
                        // Tutaj wprowadzamy nowy kod generujący kolor
                        double normalizedIter = (double)iter / maxIter; // Normalizacja liczby iteracji do zakresu 0-1

                        Color color;
                        string selectedColorScheme = KolorycomboBox.SelectedItem.ToString();
                        if (selectedColorScheme == "hsv1")
                        {
                            // HSV1
                            double hue = 360 * normalizedIter; // barwa zależy od iteracji 
                            double saturation = 1.0; // nasycenie
                            double value = 1.0; // wartość max dla punktu nie na fraktalu

                            // Konwersja z HSV na RGB
                            color = ColorFromHSV(hue, saturation, value);
                        }
                        else if (selectedColorScheme == "hsv2")
                        {
                            // HSV2
                            double hue = 360 * (1 - normalizedIter);
                            double saturation = 1.0; 
                            double value = 1.0; 

                            // HSV -> RGB
                            color = ColorFromHSV(hue, saturation, value);
                        }
                        else
                        {
                            // skala szarości
                            int grayScale = (int)(255 * normalizedIter);
                            color = Color.FromArgb(255, grayScale, grayScale, grayScale);
                        }

                        fractalBitmap.SetPixel(x, y, color);
                    }
                }

                // wyświetlanie fraktala
                ObrazPictureBox.Image = fractalBitmap;

                // resetuj przesunięcie obrazka
                _currentImageOffset = Point.Empty;
            }
        }
        private Point? _dragStartPoint = null;
        private Point _currentImageOffset = Point.Empty;

        private void ObrazPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragStartPoint = e.Location;
            }
        }

        private void ObrazPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            _dragStartPoint = null;
        }

        private void ObrazPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragStartPoint.HasValue)
            {
                var newX = _currentImageOffset.X + (_dragStartPoint.Value.X - e.X);
                var newY = _currentImageOffset.Y + (_dragStartPoint.Value.Y - e.Y);

                newX = Math.Min(Math.Max(newX, 0), ObrazPictureBox.Image.Width - ObrazPictureBox.Width);
                newY = Math.Min(Math.Max(newY, 0), ObrazPictureBox.Image.Height - ObrazPictureBox.Height);

                _currentImageOffset = new Point(newX, newY);

                ObrazPictureBox.Invalidate();
            }
        }

        private void ObrazPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (ObrazPictureBox.Image != null)
            {
                e.Graphics.Clear(ObrazPictureBox.BackColor);
                var srcRect = new Rectangle(_currentImageOffset, ObrazPictureBox.Size);
                var destRect = new Rectangle(Point.Empty, ObrazPictureBox.Size);
                e.Graphics.DrawImage(ObrazPictureBox.Image, destRect, srcRect, GraphicsUnit.Pixel);
            }
        }



        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        private float zoom = 1; // Wartość zoom, 1 oznacza 100%

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            zoom *= 2.5f; // Zwiększ zoom o 10%
            GenerateAndDisplayFractal();
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            zoom /= 2.5f; // Zmniejsz zoom o 10%
            GenerateAndDisplayFractal();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ObrazPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GenerateAndDisplayFractal();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
