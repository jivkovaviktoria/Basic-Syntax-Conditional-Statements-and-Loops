using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            double lightsabersTotal = Math.Ceiling((students + students * 0.10)*lightsabersPrice);
            int freeRobes = students / 6;
            double robesTotal = (students * robesPrice) - (freeRobes*robesPrice);
            double beltsTotal = students*beltsPrice;

            double equipmentTotal = lightsabersTotal + robesTotal + beltsTotal;

            if (money >= equipmentTotal)
            {
                Console.WriteLine($"The money is enough - it would cost {equipmentTotal:f2}lv.");
            }
            else
            {
                double neededMoney = equipmentTotal - money;
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }


        }
    }
}
