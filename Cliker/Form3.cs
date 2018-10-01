using System;
using System.Windows.Forms;

namespace Cliker
{
    public partial class Form3 : Form
    {
        LoadGame load = new LoadGame();
        OnGameForm _onGame = new OnGameForm();
        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadGame.LoadSave();
            LoadGame.UpdateSave();
            OnGameForm.OnForm1();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt"))
            {
                DialogResult dialogResult = MessageBox.Show("Если вы начнете \"Новую игру\", то ваш предыдущий прогрес обнулиться!", "  ВНИМАНИЕ!!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OnGameForm.OnForm1();
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            else
            {
                OnGameForm.OnForm1();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt"))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
