
using System;
using System.Drawing;
using System.Windows.Forms;

namespace memorygame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random r = new Random();

        int reng1, reng2, reng3, reng4;
        int reng5, reng6, reng7, reng8;

        int xal = 0;
        int birinci = 0, ikinci = 0;
        int rengA, rengB;
        int sehv1, sehv2;
        int tapilan = 0;

        bool a1 = false, a2 = false;
        bool a3 = false, a4 = false;
        bool a5 = false, a6 = false;
        bool a7 = false, a8 = false;

        bool gozle = false;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            switch (sehv1)
            {
                case 1: panel1.BackColor = Color.White; break;
                case 2: panel2.BackColor = Color.White; break;
                case 3: panel3.BackColor = Color.White; break;
                case 4: panel4.BackColor = Color.White; break;
                case 5: panel5.BackColor = Color.White; break;
                case 6: panel6.BackColor = Color.White; break;
                case 7: panel7.BackColor = Color.White; break;
                case 8: panel8.BackColor = Color.White; break;
            }

            switch (sehv2)
            {
                case 1: panel1.BackColor = Color.White; break;
                case 2: panel2.BackColor = Color.White; break;
                case 3: panel3.BackColor = Color.White; break;
                case 4: panel4.BackColor = Color.White; break;
                case 5: panel5.BackColor = Color.White; break;
                case 6: panel6.BackColor = Color.White; break;
                case 7: panel7.BackColor = Color.White; break;
                case 8: panel8.BackColor = Color.White; break;
            }

            pictureBox2.Visible = false;

            birinci = 0;
            ikinci = 0;
            gozle = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 1000;

            xal = 0;
            tapilan = 0;
            birinci = 0;
            ikinci = 0;
            gozle = false;

            label2.Text = "0";

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            a1 = false;
            a2 = false;
            a3 = false;
            a4 = false;
            a5 = false;
            a6 = false;
            a7 = false;
            a8 = false;

            reng1 = 1;
            reng2 = 1;
            reng3 = 2;
            reng4 = 2;
            reng5 = 3;
            reng6 = 3;
            reng7 = 4;
            reng8 = 4;

            for (int i = 0; i < 30; i++)
            {
                int n = r.Next(1, 9);
                int m = r.Next(1, 9);

                int temp = 0;
                int deyisen = 0;

                switch (n)
                {
                    case 1: temp = reng1; break;
                    case 2: temp = reng2; break;
                    case 3: temp = reng3; break;
                    case 4: temp = reng4; break;
                    case 5: temp = reng5; break;
                    case 6: temp = reng6; break;
                    case 7: temp = reng7; break;
                    case 8: temp = reng8; break;
                }

                switch (m)
                {
                    case 1: deyisen = reng1; break;
                    case 2: deyisen = reng2; break;
                    case 3: deyisen = reng3; break;
                    case 4: deyisen = reng4; break;
                    case 5: deyisen = reng5; break;
                    case 6: deyisen = reng6; break;
                    case 7: deyisen = reng7; break;
                    case 8: deyisen = reng8; break;
                }

                switch (n)
                {
                    case 1: reng1 = deyisen; break;
                    case 2: reng2 = deyisen; break;
                    case 3: reng3 = deyisen; break;
                    case 4: reng4 = deyisen; break;
                    case 5: reng5 = deyisen; break;
                    case 6: reng6 = deyisen; break;
                    case 7: reng7 = deyisen; break;
                    case 8: reng8 = deyisen; break;
                }

                switch (m)
                {
                    case 1: reng1 = temp; break;
                    case 2: reng2 = temp; break;
                    case 3: reng3 = temp; break;
                    case 4: reng4 = temp; break;
                    case 5: reng5 = temp; break;
                    case 6: reng6 = temp; break;
                    case 7: reng7 = temp; break;
                    case 8: reng8 = temp; break;
                }
            }

            panel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel6.BackColor = Color.White;
            panel7.BackColor = Color.White;
            panel8.BackColor = Color.White;

            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show(
                "Oyundan cixis edilsinmi?",
                "Sual",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (d == DialogResult.Yes)
            {
                Close();
            }
        }


        private void panel1_Click(object sender, EventArgs e)
        {
            if (gozle == true || a1 == true || birinci == 1)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng1 == 1) panel1.BackColor = Color.Red;
            if (reng1 == 2) panel1.BackColor = Color.Blue;
            if (reng1 == 3) panel1.BackColor = Color.Green;
            if (reng1 == 4) panel1.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 1;
                rengA = reng1;
            }
            else
            {
                ikinci = 1;
                rengB = reng1;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a1 = true;

                    if (birinci == 2) a2 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 7) a7 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (gozle == true || a2 == true || birinci == 2)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng2 == 1) panel2.BackColor = Color.Red;
            if (reng2 == 2) panel2.BackColor = Color.Blue;
            if (reng2 == 3) panel2.BackColor = Color.Green;
            if (reng2 == 4) panel2.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 2;
                rengA = reng2;
            }
            else
            {
                ikinci = 2;
                rengB = reng2;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a2 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 7) a7 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }


        private void panel3_Click(object sender, EventArgs e)
        {
            if (gozle == true || a3 == true || birinci == 3)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng3 == 1) panel3.BackColor = Color.Red;
            if (reng3 == 2) panel3.BackColor = Color.Blue;
            if (reng3 == 3) panel3.BackColor = Color.Green;
            if (reng3 == 4) panel3.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 3;
                rengA = reng3;
            }
            else
            {
                ikinci = 3;
                rengB = reng3;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a3 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 2) a2 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 7) a7 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (gozle == true || a4 == true || birinci == 4)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng4 == 1) panel4.BackColor = Color.Red;
            if (reng4 == 2) panel4.BackColor = Color.Blue;
            if (reng4 == 3) panel4.BackColor = Color.Green;
            if (reng4 == 4) panel4.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 4;
                rengA = reng4;
            }
            else
            {
                ikinci = 4;
                rengB = reng4;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a4 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 2) a2 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 7) a7 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (gozle == true || a5 == true || birinci == 5)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng5 == 1) panel5.BackColor = Color.Red;
            if (reng5 == 2) panel5.BackColor = Color.Blue;
            if (reng5 == 3) panel5.BackColor = Color.Green;
            if (reng5 == 4) panel5.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 5;
                rengA = reng5;
            }
            else
            {
                ikinci = 5;
                rengB = reng5;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a5 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 2) a2 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 7) a7 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }


        private void panel6_Click(object sender, EventArgs e)
        {
            if (gozle == true || a6 == true || birinci == 6)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng6 == 1) panel6.BackColor = Color.Red;
            if (reng6 == 2) panel6.BackColor = Color.Blue;
            if (reng6 == 3) panel6.BackColor = Color.Green;
            if (reng6 == 4) panel6.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 6;
                rengA = reng6;
            }
            else
            {
                ikinci = 6;
                rengB = reng6;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a6 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 2) a2 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 7) a7 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (gozle == true || a7 == true || birinci == 7)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng7 == 1) panel7.BackColor = Color.Red;
            if (reng7 == 2) panel7.BackColor = Color.Blue;
            if (reng7 == 3) panel7.BackColor = Color.Green;
            if (reng7 == 4) panel7.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 7;
                rengA = reng7;
            }
            else
            {
                ikinci = 7;
                rengB = reng7;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a7 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 2) a2 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 8) a8 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (gozle == true || a8 == true || birinci == 8)
                return;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (reng8 == 1) panel8.BackColor = Color.Red;
            if (reng8 == 2) panel8.BackColor = Color.Blue;
            if (reng8 == 3) panel8.BackColor = Color.Green;
            if (reng8 == 4) panel8.BackColor = Color.Yellow;

            if (birinci == 0)
            {
                birinci = 8;
                rengA = reng8;
            }
            else
            {
                ikinci = 8;
                rengB = reng8;

                if (rengA == rengB)
                {
                    xal++;
                    tapilan++;
                    a8 = true;

                    if (birinci == 1) a1 = true;
                    if (birinci == 2) a2 = true;
                    if (birinci == 3) a3 = true;
                    if (birinci == 4) a4 = true;
                    if (birinci == 5) a5 = true;
                    if (birinci == 6) a6 = true;
                    if (birinci == 7) a7 = true;

                    pictureBox1.Visible = true;
                    label2.Text = xal.ToString();

                    birinci = 0;
                    ikinci = 0;

                    if (tapilan == 4)
                    {
                        MessageBox.Show("Oyunu qazandiniz!");

                        panel1.Enabled = false;
                        panel2.Enabled = false;
                        panel3.Enabled = false;
                        panel4.Enabled = false;
                        panel5.Enabled = false;
                        panel6.Enabled = false;
                        panel7.Enabled = false;
                        panel8.Enabled = false;
                    }
                }
                else
                {
                    pictureBox2.Visible = true;
                    sehv1 = birinci;
                    sehv2 = ikinci;
                    gozle = true;
                    timer1.Start();
                }
            }
        }
    }
}



