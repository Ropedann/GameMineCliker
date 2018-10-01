using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliker
{
    public partial class Form2 : Form
    {
        Image PickMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "Pick_hover.png");
        Image PickMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "Pick.png");
        Image RockMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "rock_hover.png");
        Image RockMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "rock.png");
        Image EarthMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "earth_hover.png");
        Image EarthMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "Earth.png");
        Image GoldMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "gold_hover.png");
        Image GoldMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "gold.png");
        Image CoalMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "coal_hover.png");
        Image CoalMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "coal.png");
        Image MinerMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "miner_hover.png");
        Image MinerMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "miner.png");

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Улучшение клика
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 upgrade_pick = this.Owner as Form1;
            if (upgrade_pick != null)
            {
                if (Program.money >= Program.ClicSell)
                {
                    Program.bonus += 1;
                    string _bounus = upgrade_pick.label10.Text;
                    upgrade_pick.label10.Text = Convert.ToString(Program.bonus);
 
                    Program.money -= Program.ClicSell;
                    string _money = upgrade_pick.label1.Text;
                    upgrade_pick.label1.Text = Convert.ToString(Program.money);
                    Program.ClicSell *= 2;
                    label4.Text = Convert.ToString(Program.ClicSell);
                }
                else
                {
                    MessageBox.Show("У вас не достаточно монет!");
                }
            }
 
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = PickMouseHover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = PickMouseLeave;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = RockMouseHover;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = RockMouseLeave;
        }

        // Продажа камня
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 sell_rock = this.Owner as Form1;
            if (sell_rock != null)
            {
                Program.money += Program.rock * 2;
                Program.rock -= Program.rock;
                string _rock = sell_rock.label15.Text;
                sell_rock.label15.Text = Convert.ToString(Program.rock);
                string _money = sell_rock.label1.Text;
                sell_rock.label1.Text = Convert.ToString(Program.money);
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = EarthMouseHover;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = EarthMouseLeave;
        }

        // Продажа земли
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 sell_earth = this.Owner as Form1;
            if (sell_earth != null)
            {
                Program.money += Program.earth;
                Program.earth -= Program.earth;
                string _earth = sell_earth.label18.Text;
                sell_earth.label18.Text = Convert.ToString(Program.earth);
                string _money = sell_earth.label1.Text;
                sell_earth.label1.Text = Convert.ToString(Program.money);
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = GoldMouseHover;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackgroundImage = GoldMouseLeave;
        }

        // Продажа золота
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 sell_gold = this.Owner as Form1;
            if (sell_gold != null)
            {
                Program.money += Program.gold * 3;
                Program.gold -= Program.gold;
                string _gold = sell_gold.label16.Text;
                sell_gold.label16.Text = Convert.ToString(Program.gold);
                string _money = sell_gold.label1.Text;
                sell_gold.label1.Text = Convert.ToString(Program.money);
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = CoalMouseHover;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackgroundImage = CoalMouseLeave;
        }

        // Продажа угля
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form1 sell_coal = this.Owner as Form1;
            if (sell_coal != null)
            {
                Program.money += Program.coal + 5;
                Program.coal -= Program.coal;
                string _coal = sell_coal.label14.Text;
                sell_coal.label14.Text = Convert.ToString(Program.coal);
                string _money = sell_coal.label1.Text;
                sell_coal.label1.Text = Convert.ToString(Program.money);
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = MinerMouseHover;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackgroundImage = MinerMouseLeave;
        }
        // Покупка шахтера
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form1 miner_sell = this.Owner as Form1;
            if (miner_sell != null)
            {
                if (Program.money >= Program.autoClicSell)
                {
                    Program.money -= Program.autoClicSell;
                    miner_sell.timer1.Enabled = true;
                    Program.autoClicSell *= 3;
                    label8.Text = Convert.ToString(Program.autoClicSell);
                    miner_sell.label14.Text = Convert.ToString(Program.coal);
                    Program.autoClic += 1;
                    Program.strClicMiner += 1;
                    string _AutoClic = miner_sell.label7.Text;
                    miner_sell.label7.Text = Convert.ToString(Program.autoClic);
                    string _HpMinerMax = miner_sell.label5.Text;
                    miner_sell.label5.Text = Convert.ToString(Program.HpMinerMax);

                }
                else
                {
                    MessageBox.Show("У вас не хватает монет");
                }
                
                string _money = miner_sell.label1.Text;
                miner_sell.label1.Text = Convert.ToString(Program.money);
            }
        }
    }
}
