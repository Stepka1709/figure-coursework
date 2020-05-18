using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class FormFigure : Form
    {
        const int default_size = 40;

        int a;
        int v = 1;
        int s = 1;
        int dirR = 1;
        int dirX = 1;
        int dirY = 1;

        double xc, yc;
        double dx = 0.1;
        double dy = 0.1;
        double fi;
        double c_fi = 0;

        bool checkX, checkY;

        Point[] square = new Point[4];
        Point[] rhombus = new Point[4];
        Point[] triangle_1 = new Point[3];
        Point[] triangle_2 = new Point[3];
        Point[] triangle_3 = new Point[3];
        Point[] triangle_4 = new Point[3];

        double[] x = new double[16];
        double[] y = new double[16];

        public FormFigure()
        {
            InitializeComponent();
        }

        private void FormFigure_Load(object sender, EventArgs e)
        {
            a = default_size;

            xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
            yc = Convert.ToInt32(pictureBoxFigure.Height - (a * Math.Sqrt(2) / 2));

            trackBarSize.Value = a;
            trackBarSpeed.Value = v;
            trackBarRotationSpeed.Value = s;
        }

        private double[] x_rot(double[] x0, double[] y0)
        {
            double[] x1 = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                x1[i] = (x0[i]) * Math.Cos(c_fi) - (y0[i]) * Math.Sin(c_fi);
            }
            return x1;
        }

        private double[] y_rot(double[] x0, double[] y0)
        {
            double[] y1 = new double[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y1[i] = (y0[i]) * Math.Cos(c_fi) + (x0[i]) * Math.Sin(c_fi);
            }
            return y1;
        }

        private byte colorInc()
        {
            try
            {
                double col = 225 * (xc - (a / 2) * Math.Cos(Math.PI / 6)) /
                    (pictureBoxFigure.Width - a * Math.Cos(Math.PI / 6));
                return Convert.ToByte(col);
            }
            catch
            {
                return 0;
            }
        }

        private byte colorDec()
        {
            try
            {
                double col = -225 * ((xc - (a / 2) * Math.Cos(Math.PI / 6)) /
                    (pictureBoxFigure.Width - a * Math.Cos(Math.PI / 6))) + 225;
                return Convert.ToByte(col);

            }
            catch
            {
                return 0;
            }
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            a = trackBarSize.Value;

            if (!timerMovement.Enabled)
            {
                xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
                yc = Convert.ToInt32(pictureBoxFigure.Height - (a * Math.Sqrt(2) / 2));

                figure();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            v = trackBarSpeed.Value;
        }

        private void trackBarRotationSpeed_Scroll(object sender, EventArgs e)
        {
            s = trackBarRotationSpeed.Value;
        }

        private void textBoxStartingX_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32(textBoxStartingX.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingX.Text) + Convert.ToInt32(a * Math.Sqrt(2) / 2) > pictureBoxFigure.Width)
                {
                    xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
                    labelErrors.Text = String.Format("Ошибка! Начальная координата ''X'' находится за координатной плоскостью.");
                }
                else
                {
                    xc = Convert.ToInt32(textBoxStartingX.Text);
                    labelErrors.Text = String.Format("Ошибок не обнаружено.");
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartingY.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingY.Text) + Convert.ToInt32(a * Math.Sqrt(2) / 2) > pictureBoxFigure.Height)
                {
                    yc = Convert.ToInt32(pictureBoxFigure.Height - (a * Math.Sqrt(2) / 2));
                    labelErrors.Text = String.Format("Ошибка! Начальная координата ''Y'' находится за координатной плоскостью.");
                }
                else
                {
                    yc = Convert.ToInt32(textBoxStartingY.Text);
                    labelErrors.Text = String.Format("Ошибок не обнаружено.");
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingDirectionX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartingX.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingX.Text) > pictureBoxFigure.Width)
                {
                    labelErrors.Text = String.Format("Ошибка! Начальное направление ''X'' находится за координатной плоскостью.");
                }
                else
                {
                    labelErrors.Text = String.Format("Ошибок не обнаружено.");
                }
            }
            catch
            {

            }
        }

        private void textBoxStartingDirectionY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBoxStartingY.Text) < Convert.ToInt32(a * Math.Sqrt(2) / 2) || Convert.ToInt32(textBoxStartingY.Text) > pictureBoxFigure.Height)
                {
                    labelErrors.Text = String.Format("Ошибка! Начальное направление ''X'' находится за координатной плоскостью.");
                }
                else
                {
                    labelErrors.Text = String.Format("Ошибок не обнаружено.");
                }
            }
            catch
            {

            }
        }

        private void timerMovement_Tick(object sender, EventArgs e)
        {
            if (x.Max() + xc > pictureBoxFigure.Width && checkX)
            {
                dirX = -1;
                checkX = false;

                if (dirY == -1)
                {
                    dirY = 1;
                    checkY = true;
                }
                else
                {
                    dirY = -1;
                    checkY = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            if (x.Min() + xc < 0 && !checkX)
            {
                dirX = 1;
                checkX = true;

                if (dirY == -1)
                {
                    dirY = 1;
                    checkY = true;
                }
                else
                {
                    dirY = -1;
                    checkY = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            if (y.Max() + yc > pictureBoxFigure.Height && checkY)
            {
                dirY = -1;
                checkY = false;

                if (dirX == -1)
                {
                    dirX = 1;
                    checkX = true;
                }
                else
                {
                    dirX = -1;
                    checkX = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            if (y.Min() + yc < 0 && !checkY)
            {
                dirY = 1;
                checkY = true;

                if (dirX == -1)
                {
                    dirX = 1;
                    checkX = true;
                }
                else
                {
                    dirX = -1;
                    checkX = false;
                }

                if (dirR == 1) dirR = -1;
                else dirR = 1;
            }

            c_fi += fi * s;
            fi = dirR * Math.PI / (180);

            xc = xc + dx * dirX * v;
            yc = yc + dy * dirY * v;

            figure();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            figure();
        }

        private void buttonMovement_Click(object sender, EventArgs e)
        {
            if (dx != 0.1 && dy != 0.1)
            {
                timerMovement.Start();
                labelErrors.Text = String.Format("Ошибок не обнаружено.");
            }
            else
            {
                labelErrors.Text = String.Format("Ошибка! Начальное направление не задано.");
            }
        }

        private void buttonEnterCoord_Click(object sender, EventArgs e)
        {
            try
            {
                double hypotehuse = Math.Pow((Convert.ToInt32(textBoxStartingDirectionX.Text) - xc), 2) + Math.Pow((Convert.ToInt32(textBoxStartingDirectionY.Text) - yc), 2);
                dx = Math.Abs((Convert.ToInt32(textBoxStartingDirectionX.Text) - xc)) / Math.Sqrt(hypotehuse);
                dy = Math.Abs((Convert.ToInt32(textBoxStartingDirectionY.Text) - yc)) / Math.Sqrt(hypotehuse);

                if (Convert.ToInt32(textBoxStartingDirectionX.Text) > xc)
                {
                    dirX = 1;
                    checkX = true;
                }
                else
                {
                    dirX = -1;
                    checkX = false;
                }

                if (Convert.ToInt32(textBoxStartingDirectionY.Text) > yc)
                {
                    dirY = 1;
                    checkY = true;
                }
                else
                {
                    dirY = -1;
                    checkY = false;
                }
            }
            catch
            {

            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerMovement.Stop();

            xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
            yc = Convert.ToInt32(pictureBoxFigure.Height - (a * Math.Sqrt(2) / 2));

            dx = 0.1;
            dy = 0.1;
            c_fi = 0;

            textBoxStartingX.Clear();
            textBoxStartingY.Clear();
            textBoxStartingDirectionX.Clear();
            textBoxStartingDirectionY.Clear();

            figure();
        }

        private void buttonDefaultSize_Click(object sender, EventArgs e)
        {
            a = default_size;
            trackBarSize.Value = default_size;

            if (!timerMovement.Enabled)
            {
                xc = Convert.ToInt32(a * Math.Sqrt(2) / 2);
                yc = Convert.ToInt32(pictureBoxFigure.Height - (a * Math.Sqrt(2) / 2));

                figure();
            }
        }

        private void figure()
        {
            Graphics g = pictureBoxFigure.CreateGraphics();
            Brush b_square = new SolidBrush(Color.FromArgb(colorInc(), 0, colorDec()));
            Brush b_rhombus = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc()));
            Brush b_triangle_1 = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc()));
            Brush b_triangle_2 = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc()));
            Brush b_triangle_3 = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc()));
            Brush b_triangle_4 = new SolidBrush(Color.FromArgb(colorDec(), colorDec(), colorInc()));
            g.Clear(SystemColors.Control);

            x[0] = Convert.ToInt32(0);
            y[0] = Convert.ToInt32(-(a * Math.Sqrt(2) / 2));
            x[1] = Convert.ToInt32((a * Math.Sqrt(2) / 2));
            y[1] = Convert.ToInt32(0);
            x[2] = Convert.ToInt32(0);
            y[2] = Convert.ToInt32((a * Math.Sqrt(2) / 2));
            x[3] = Convert.ToInt32(-(a * Math.Sqrt(2) / 2));
            y[3] = Convert.ToInt32(0);
            //
            x[4] = Convert.ToInt32(-(a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            y[4] = Convert.ToInt32((a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            x[5] = Convert.ToInt32(-(a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            y[5] = Convert.ToInt32(-(a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            x[6] = Convert.ToInt32((a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            y[6] = Convert.ToInt32(-(a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            x[7] = Convert.ToInt32((a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            y[7] = Convert.ToInt32((a * Math.Sqrt(2) / 2) * Math.Cos(Math.PI / 4));
            //
            x[8] = Convert.ToInt32(0);
            y[8] = Convert.ToInt32(-(a / 2));
            x[9] = Convert.ToInt32(+(a / 2) * Math.Cos(Math.PI / 4));
            y[9] = Convert.ToInt32(-(a / 2) * Math.Cos(Math.PI / 4));
            //
            x[10] = Convert.ToInt32((a / 2));
            y[10] = Convert.ToInt32(0);
            x[11] = Convert.ToInt32((a / 2) * Math.Cos(Math.PI / 4));
            y[11] = Convert.ToInt32((a / 2) * Math.Cos(Math.PI / 4));
            //
            x[12] = Convert.ToInt32(0);
            y[12] = Convert.ToInt32((a / 2));
            x[13] = Convert.ToInt32(-(a / 2) * Math.Cos(Math.PI / 4));
            y[13] = Convert.ToInt32((a / 2) * Math.Cos(Math.PI / 4));
            //
            x[14] = Convert.ToInt32(-(a / 2));
            y[14] = Convert.ToInt32(0);
            x[15] = Convert.ToInt32(-(a / 2) * Math.Cos(Math.PI / 4));
            y[15] = Convert.ToInt32(-(a / 2) * Math.Cos(Math.PI / 4));

            double[] temp = new double[16];
            temp = x;
            x = x_rot(temp, y);
            y = y_rot(temp, y);

            rhombus[0] = new Point((int)(x[0] + xc), (int)(y[0] + yc));
            rhombus[1] = new Point((int)(x[1] + xc), (int)(y[1] + yc));
            rhombus[2] = new Point((int)(x[2] + xc), (int)(y[2] + yc));
            rhombus[3] = new Point((int)(x[3] + xc), (int)(y[3] + yc));

            square[0] = new Point((int)(x[4] + xc), (int)(y[4] + yc));
            square[1] = new Point((int)(x[5] + xc), (int)(y[5] + yc));
            square[2] = new Point((int)(x[6] + xc), (int)(y[6] + yc));
            square[3] = new Point((int)(x[7] + xc), (int)(y[7] + yc));

            triangle_1[0] = new Point((int)(xc), (int)(yc));
            triangle_1[1] = new Point((int)(x[8] + xc), (int)(y[8] + yc));
            triangle_1[2] = new Point((int)(x[9] + xc), (int)(y[9] + yc));

            triangle_2[0] = new Point((int)(xc), (int)(yc));
            triangle_2[1] = new Point((int)(x[10] + xc), (int)(y[10] + yc));
            triangle_2[2] = new Point((int)(x[11] + xc), (int)(y[11] + yc));

            triangle_3[0] = new Point((int)(xc), (int)(yc));
            triangle_3[1] = new Point((int)(x[12] + xc), (int)(y[12] + yc));
            triangle_3[2] = new Point((int)(x[13] + xc), (int)(y[13] + yc));

            triangle_4[0] = new Point((int)(xc), (int)(yc));
            triangle_4[1] = new Point((int)(x[14] + xc), (int)(y[14] + yc));
            triangle_4[2] = new Point((int)(x[15] + xc), (int)(y[15] + yc));

            g.FillPolygon(b_rhombus, rhombus);
            g.FillPolygon(b_square, square);
            g.FillPolygon(b_triangle_1, triangle_1);
            g.FillPolygon(b_triangle_2, triangle_2);
            g.FillPolygon(b_triangle_3, triangle_3);
            g.FillPolygon(b_triangle_4, triangle_4);

            labelCoord.Text = String.Format("X: {0:0.00}, Y: {1:0.00}", xc, yc);
        }
    }
}