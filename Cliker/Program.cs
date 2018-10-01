using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliker
{
    public class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form3());
            

        }
        public static int money = 0; // Количество денег
        public static int rock = 0; // Количество камня
        public static int coal = 0; // Количество угля
        public static int gold = 0; // Количество золота
        public static int earth = 0; // Количество земли
        public static int clic = 1; // Сила клика
        public static int bonus = 0; // бонус клика
        public static int ClicSell = 20; // Стоимость бонуса
        public static int autoClicSell = 200; // Стоимость шахтера
        public static int Counter = 0; // Счетчик 
        public static int autoClic = 0; // Количество шахтеров
        public static int strClicMiner = 0;
        public static int Chance = 0; // Шанс дропа
        public static int CritAtak = 0; // Крит удар
        public static int HpMinerMax = 100; // Максимальное здоровье
        public static int HpMinerValue = 100; // Текущие здоровье
        public static int timernum; // Временная переменная
        public static int lvl = bonus + strClicMiner + autoClic * 10; // Уровень
    }
}
