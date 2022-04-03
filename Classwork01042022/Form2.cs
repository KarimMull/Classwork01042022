using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;


namespace Classwork01042022
{
    public partial class Main_Form : Form
    {
        Skrimerform skrimerform = new Skrimerform();
        Random rnd = new Random();
        List<int> generate_array = new List<int>(Enumerable.Range(1, 17).ToArray());
        List<Image> images = new List<Image>(Enumerable.Repeat<Image>(null,16));
        List<int> number_of_win_position = new List<int>(Enumerable.Repeat<int>(0, 10));
        List<bool> status_of_win = new List<bool>(Enumerable.Repeat<bool>(false, 10));
        int value;
        bool win = false;

        public Main_Form()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i=1;i<=10;i++)
            {
                value = rnd.Next(generate_array.Count);
                switch(generate_array[value])
                {
        
                    case 1: images[0] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(1); break;
                    case 2: images[1] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(2); break;
                    case 3: images[2] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(3); break;
                    case 4: images[3] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(4); break;
                    case 5: images[4] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(5); break;
                    case 6: images[5] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(6); break;
                    case 7: images[6] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(7); break;
                    case 8: images[7] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(8); break;
                    case 9: images[8] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(9); break;
                    case 10: images[9] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(10); break;
                    case 11: images[10] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(11); break;
                    case 12: images[11] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(12); break;
                    case 13: images[12] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(13); break;
                    case 14: images[13] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(14); break;
                    case 15: images[14] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(15); break;
                    case 16: images[15] = (Image)new Bitmap($"{i}.jpg"); number_of_win_position.Add(16); break;
                }
                generate_array.RemoveAt(value);
            }
            foreach (int i in generate_array)
            {
                switch (i)
                {
                    case 1: images[0] = (Image)new Bitmap($"nature{i % 6 +1}.jpg"); break;
                    case 2: images[1] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 3: images[2] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 4: images[3] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 5: images[4] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 6: images[5] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 7: images[6] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 8: images[7] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 9: images[8] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 10: images[9] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 11: images[10] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 12: images[11] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 13: images[12] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 14: images[13] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 15: images[14] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;
                    case 16: images[15] = (Image)new Bitmap($"nature{i % 6 + 1}.jpg"); break;

                }
             
            }



            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressBar1.Maximum = 300;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 300)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                if(!win)
                {
                    skrimerform.Show();
                    using (StreamWriter sw = File.AppendText(@"Classwork01042022.txt"))
                    {
                        sw.WriteLine( $"{Data.Name} - Lose");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(@"Classwork01042022.txt"))
                    {
                        sw.WriteLine($"{Data.Name} - Win");
                    }
                }
               
            }
        }
        private void incorrect_pressing()
        {
            Thread.Sleep(10);
            pictureBox1.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox2.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox3.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox4.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox5.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox6.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox7.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox8.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox9.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox10.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox11.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox12.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox13.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox14.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox15.Image = (Image)new Bitmap($"pushme.jpg");
            pictureBox16.Image = (Image)new Bitmap($"pushme.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            int index = Convert.ToInt32(p.Tag);

            switch(index)
            {
                case 1: pictureBox1.Image = images[0]; break;
                case 2: pictureBox2.Image = images[1]; break;
                case 3: pictureBox3.Image = images[2]; break;
                case 4: pictureBox4.Image = images[3]; break;
                case 5: pictureBox5.Image = images[4]; break;
                case 6: pictureBox6.Image = images[5]; break;
                case 7: pictureBox7.Image = images[6]; break;
                case 8: pictureBox8.Image = images[7]; break;
                case 9: pictureBox9.Image = images[8]; break;
                case 10: pictureBox10.Image = images[9]; break;
                case 11: pictureBox11.Image = images[10]; break;
                case 12: pictureBox12.Image = images[11]; break;
                case 13: pictureBox13.Image = images[12]; break;
                case 14: pictureBox14.Image = images[13]; break;
                case 15: pictureBox15.Image = images[14]; break;
                case 16: pictureBox16.Image = images[15]; break;
            }
            if(number_of_win_position.IndexOf(index) != -1)
            {
                status_of_win[(index - 1)%10] = true;
                int count = 0;
                for(int i=0;i<10;i++)
                {
                    if(status_of_win[i] == true)
                    {
                        count++;
                    }
                }
                if(count == 9)
                {
                    win = true;
                    MessageBox.Show("Вы выиграли");
                    using (StreamWriter sw = File.AppendText(@"Classwork01042022.txt"))
                    {
                        sw.WriteLine($"{Data.Name} - Win");
                    }
                }
            }
            else 
            {
                incorrect_pressing();
            }
        }

    }
}
