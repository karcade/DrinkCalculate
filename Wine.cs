using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkProduction
{
    class Wine:Drink //Класс Вино
    {
        string grapeSort; //название сорта винограда
        double grapeSortCost; //стоимость сорта винограда

        //Свйоство: название сорта винограда
        public string GrapeSort
        {
            get { return grapeSort; }
        }

        //Свйоство: стоимость сорта винограда
        public double GrapeSortCost
        {
            get { return grapeSortCost; }
        }

        //Конструктор
        public Wine(string name, double workPayment, double electricEnergyCost, 
            string grapeSort, double grapeSortCost)
            : base(name, workPayment, electricEnergyCost)
        {
            this.grapeSort = grapeSort;
            this.grapeSortCost = grapeSortCost; //технические, белые, красные
        }

        //Метод: стоимость 1 литра вина
        public override double Cost()
        {
            double cost = workPayment + electricEnergyCost + grapeSortCost;
            return Math.Round(cost, 2);
        }
        
        //Метод: информация о вине
        public override string Info()
        {
            string str = $"\nВино.\nНазвание: \"{name}\". \nЗатраты на труд: {workPayment} руб." +
                $"\nСтоимость электроэнергии: {electricEnergyCost} руб. " +
                $"\nСорт винограда: {grapeSort}. Стоимость винограда: {grapeSortCost}руб." +
                $"\n Цена за л: {Cost()} руб.";
            return str;
        }
    }
}
