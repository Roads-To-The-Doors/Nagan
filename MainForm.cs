using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Nagan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool[] ammo =
        {
            false, false, false, false, false, false, false
        };

        SoundPlayer wave = null;

        private bool SetAmmo(bool set)
        {
            if (set)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool[] NewAmmo()
        {
            int length = ammo.Length;

            Random random = new Random();

            int rand = random.Next(length);

            bool[] am = new bool[length];

            if (rand == 0)
            {
                for (int i = 0; i < length; ++i)
                {
                    am[i] = ammo[i];
                }
            }
            else
            {
                int count = 0;

                for (int i = rand; i < length; ++i)
                {
                    am[count] = ammo[i];

                    ++count;
                }

                for (int i = 0; i < rand; ++i)
                {
                    am[count] = ammo[i];

                    ++count;
                }
            }

            return am;
        }

        private void Out()
        {
            int i = 0;

            if (ammo[i])
            {
                button1.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button1.BackgroundImage = null;
            }

            ++i;

            if (ammo[i])
            {
                button2.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button2.BackgroundImage = null;
            }

            ++i;

            if (ammo[i])
            {
                button3.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button3.BackgroundImage = null;
            }

            ++i;

            if (ammo[i])
            {
                button4.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button4.BackgroundImage = null;
            }

            ++i;

            if (ammo[i])
            {
                button5.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button5.BackgroundImage = null;
            }

            ++i;

            if (ammo[i])
            {
                button6.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button6.BackgroundImage = null;
            }

            ++i;

            if (ammo[i])
            {
                button7.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button7.BackgroundImage = null;
            }
        }

        private void Sorted()
        {
            int length = ammo.Length;

            bool buffer = ammo[0];

            for (int i = 1; i < length; ++i)
            {
                ammo[i - 1] = ammo[i];
            }

            ammo[length - 1] = buffer;
        }

        /****************************************************/
        /****************************************************/

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button1.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button1.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button2.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button2.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 2;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button3.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button3.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int i = 3;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button4.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button4.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int i = 4;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button5.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button5.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i = 5;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button6.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button6.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int i = 6;

            ammo[i] = SetAmmo(ammo[i]);

            if (ammo[i])
            {
                button7.BackgroundImage = Properties.Resources.Патрон;
            }
            else
            {
                button7.BackgroundImage = null;
            }

            wave = new SoundPlayer(Properties.Resources.ЗаряжениеПулей);

            wave.Play();
        }
        
        /****************************************************/
        /****************************************************/

        private void chamber_Click(object sender, EventArgs e)
        {
            if (panel1.Visible)
            {
                panel1.Visible = false;

                twist.Visible = true;

                shot.Visible = true;

                wave = new SoundPlayer(Properties.Resources.Закрытие);
            }
            else
            {
                panel1.Visible = true;

                twist.Visible = false;

                shot.Visible = false;

                Out();

                wave = new SoundPlayer(Properties.Resources.Открытие);
            }

            wave.Play();
        }

        private void shot_Click(object sender, EventArgs e)
        {
            if (ammo[0] == true)
            {
                ammo[0] = false;

                wave = new SoundPlayer(Properties.Resources.Выстрел);
            }
            else
            {
                wave = new SoundPlayer(Properties.Resources.Пустой);
            }
            
            Sorted();

            wave.Play();
        }

        private void twist_Click(object sender, EventArgs e)
        {
            ammo = NewAmmo();

            wave = new SoundPlayer(Properties.Resources.КручениеБарабана);

            wave.Play();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            shot.Visible = false;

            twist.Visible = false;
        }
    }
}
