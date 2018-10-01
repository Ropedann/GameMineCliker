using System;
using System.IO;


namespace Cliker

{
   public class SaveGame
    {
        Program param = new Program();
        public static void StartSave()
        {
            File.WriteAllLines(Environment.CurrentDirectory + @"\MinerClikerSave\" + "save.txt", new string[]
            {
              "1) Монеты:", Program.money.ToString(),
              "2) Камень:", Program.rock.ToString(),
              "3) Уголь", Program.coal.ToString(),
              "4) Золото:", Program.gold.ToString(),
              "5) Земля:", Program.earth.ToString(),
              "6) Клик:", Program.clic.ToString(),
              "7) Бонус:", Program.bonus.ToString(),
              "8) Стоимость Бонуса:", Program.ClicSell.ToString(),
              "9) Стоимость шахтера:", Program.autoClicSell.ToString(),
              "10) Счетчик:", Program.Counter.ToString(),
              "11) Количество шахтеров:", Program.autoClic.ToString(),
              "12) Сила шахтера:", Program.strClicMiner.ToString(),
              "13) Шанс:", Program.Chance.ToString(),
              "14) Крит.Атака:", Program.CritAtak.ToString(),
              "15) Максимальное здоровье:", Program.HpMinerMax.ToString(),
              "16) Текущее здоровье:", Program.HpMinerValue.ToString(),
              "17) Временная переменная:", Program.timernum.ToString(),
              "18) Уровень:",Program.lvl.ToString()
            });
        }

    }
    
}
