using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Cliker
{
    public partial class Form1 : Form
    {
        
        
        Image MineMouseHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "mine_1hover.png");
        Image MineMouseLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "mine_1leave.png");
        Image NpcMousHover = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "shop_Hover.png");
        Image NpcMousLeave = Image.FromFile(Environment.CurrentDirectory + @"\image\" + "shop_Leave.png");
        SaveGame _save = new SaveGame();
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //Отключаем кнопку починки и надпись "Ремонт"
            label19.Visible = false;
            button1.Visible = false;
            label5.Text = Convert.ToString(Program.HpMinerValue) + "/" + Convert.ToString(Program.HpMinerMax);
            Directory.CreateDirectory(Environment.CurrentDirectory + @"\MinerClikerSave\");
            label1.Text = Convert.ToString(Program.money);
            label14.Text = Convert.ToString(Program.coal);
            label15.Text = Convert.ToString(Program.rock);
            label16.Text = Convert.ToString(Program.gold);
            label18.Text = Convert.ToString(Program.earth);
            Form1 loading_game = this.Owner as Form1;
            if (loading_game != null)
            {
                loading_game.label10.Text = Convert.ToString(Program.bonus);
                loading_game.label7.Text = Convert.ToString(Program.autoClic);
                loading_game.label5.Text = Convert.ToString(Program.HpMinerValue) + "/" + Convert.ToString(Program.HpMinerMax);
            }
            //Program.money = Convert.ToInt32(File.ReadAllLines(@"C:\Users\ASUS\Documents\MinerClikerSave\save.txt")[1]);

        }

        // Функция шахтера
        public void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // Свойвство рандома
            Random rand = new Random();
            Program.Chance = rand.Next(1, 50);
            if (Program.Chance > 45)
            {
                // Добавление золота
                Program.gold += Program.strClicMiner;
                label16.Text = Convert.ToString(Program.gold);
            }
            else if (Program.Chance > 40)
            {
                // Добавление Камня
                Program.rock += Program.strClicMiner;
                label15.Text = Convert.ToString(Program.rock);
            }
            else if (Program.Chance > 25)
            {
                // Добавление угля
                Program.coal += Program.strClicMiner;
                label14.Text = Convert.ToString(Program.coal);
            }
            else
            {
                // Добавление земли
                Program.earth += Program.strClicMiner;
                label18.Text = Convert.ToString(Program.earth);
            }
            if (Program.HpMinerValue > 0)
            {
                Program.HpMinerValue -= Program.strClicMiner;
                label5.Text = Convert.ToString(Program.HpMinerValue) + " / " + Convert.ToString(Program.HpMinerMax);
            }
            else
            {
                Program.timernum += Program.strClicMiner;
                Program.strClicMiner -= Program.strClicMiner;
                pictureBox2.Enabled = false;
                label19.Visible = true;
                button1.Visible = true;
            }
          

        }
        // Функция нажимания на шахту
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            //Функция рандома
            Random rand = new Random();
            Program.Chance = rand.Next(1, 50);
            if (Program.Chance > 45)
            {
                // Добавление золота
                Program.gold += Program.clic + Program.bonus;

                label16.Text = Convert.ToString(Program.gold);
            }
            else if (Program.Chance > 40)
            {
                // Добавление камня
                Program.rock += Program.clic + Program.bonus;
                label15.Text = Convert.ToString(Program.rock);
            }
            else if (Program.Chance > 25)
            {
                // Добавление угля
                Program.coal += Program.clic + Program.bonus;
                label14.Text = Convert.ToString(Program.coal);
            }
            else
            {
                // Добавление земли
                Program.earth += Program.clic + Program.bonus;
                label18.Text = Convert.ToString(Program.earth);
            }
                label1.Text = Convert.ToString(Program.money);
            // При каждом клике уменьшается здоровье шахты
            Program.HpMinerValue -= Program.clic + Program.bonus;
            label5.Text = Convert.ToString(Program.HpMinerValue) + "/" + Convert.ToString(Program.HpMinerMax);
            // цвет шахты


            if (Program.HpMinerValue <= 0)
            {
                // Когзда хп кончилось возможность нажать на шахту отключается
                pictureBox2.Enabled = false;
                // Включаем надпись ремонт и показываем кнопку поченить
                label19.Visible = true;
                button1.Visible = true;
            }
            // Условие для постоянного прибавления ресурсов
            if (Program.Counter > -1)
            {
                Program.Counter = 0;
            }
        }

        // Функции изменения изображения при наведении мышки 
        public void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = MineMouseHover;
        }

        public void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackgroundImage = MineMouseLeave;
        }

        public void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = NpcMousLeave;
        }

        public void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackgroundImage = NpcMousHover;
        }

        // Функция открытия магазина
        public void pictureBox3_Click(object sender, EventArgs e)
        {
            Form2 Shop = new Form2();
            Shop.Owner = this;
            Shop.Show();
            Shop.label4.Text = Convert.ToString(Program.ClicSell);
            Shop.label8.Text = Convert.ToString(Program.autoClicSell);
        }

        // Функция кнопки ремонта
        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.money >= 30)
            {
                pictureBox2.Enabled = true;
                label19.Visible = false;
                button1.Visible = false;
                Program.HpMinerValue += Program.HpMinerMax;
                Program.money -= 30 + Program.bonus;
                Program.strClicMiner += Program.timernum;
                Program.timernum -= Program.timernum;
                label1.Text = Convert.ToString(Program.money);
                Program.HpMinerMax += Program.bonus + Program.strClicMiner * 3;
                label5.Text = Convert.ToString(Program.HpMinerValue) + "/" + Convert.ToString(Program.HpMinerMax);
            }
            else
            {
                MessageBox.Show("У вас не достаточно денег!");
            }
        }

        // Кнопка выход
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SaveGame.StartSave();
        }
    }
}
