using System;
using System.IO;

namespace Cliker
{

    public class LoadGame
    {
        
        public static void UpdateSave()
        {
            Form1 update = new Form1();
            update.label1.Text = Convert.ToString(Program.money);
            update.label14.Text = Convert.ToString(Program.coal);
            update.label15.Text = Convert.ToString(Program.rock);
            update.label16.Text = Convert.ToString(Program.gold);
            update.label18.Text = Convert.ToString(Program.earth);
            update.label10.Text = Convert.ToString(Program.bonus);
            update.label7.Text = Convert.ToString(Program.autoClic);
            update.label5.Text = Convert.ToString(Program.HpMinerValue) + "/" + Convert.ToString(Program.HpMinerMax);
        }
        public static void LoadSave()
        {
            Program loadsave = new Program();

            Program.money = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[1]);  // Количество денег
            Program.rock = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[3]); // Количество камня
            Program.coal = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[5]); // Количество угля
            Program.gold = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[7]); // Количество золота
            Program.earth = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[9]); // Количество земли
            Program.clic = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[11]);// Сила клика
            Program.bonus = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[13]); // бонус клика
            Program.ClicSell = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[15]); // Стоимость бонуса
            Program.autoClicSell = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[17]);// Стоимость шахтера
            Program.Counter = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[19]); // Счетчик 
            Program.autoClic = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[21]); // Количество шахтеров
            Program.strClicMiner = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[23]);
            Program.Chance = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[25]); // Шанс дропа
            Program.CritAtak = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[27]); // Крит удар
            Program.HpMinerMax = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[29]); // Максимальное здоровье
            Program.HpMinerValue = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[31]); // Текущие здоровье
            Program.timernum = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[33]); ; // Временная переменная
            Program.lvl = Convert.ToInt32(File.ReadAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt")[35]); // Уровень
        }

            
}
}
