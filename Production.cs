using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkProduction
{
    class Production
    {
        Drink beverage; //напиток
        DateTime outputDate; //дата выпуска продукции
        DateTime pullDate; //срок годности
        double amount; //количество напитка (в литрах)

        //Свойство: дата выпуска продукции
        public DateTime OutputDate
        {
            get { return outputDate; }
        }

        //Свойство: срок годности
        public DateTime PullDate
        {
            get { return pullDate; }
        }

        //Свйоство: напиток
        public Drink Beverage
        { 
            get { return beverage; } 
        }

        //Свйоство: количество напитка (в литрах)
        public double Amount
        {
            get { return amount; }
        }

        //Конструктор
        public Production(Drink beverage, DateTime outputDate, DateTime pulldate, double amount)
        {
            this.beverage = beverage;
            this.outputDate = outputDate;
            this.pullDate = pullDate;
            this.amount = amount;
        }

        //Метод: стоимость произведенной продукции
        public double CostProduction()
        {
            double cost;
            if (DateTime.Now == pullDate) cost = 0;
            else
            {
                cost = beverage.Cost() * amount;
                if (beverage is Wine) cost=cost*1.1*Convert.ToInt32(DateTime.Now.Year-outputDate.Year);
            }
            return Math.Round(cost,2);
        }

        //Метод: информация о продукции
        public string Info()
        {
            string str = beverage.Info() + $"\nКоличество: {amount} л. " +
                $"Cтоимость: {CostProduction()} руб. Дата производства: {outputDate.ToShortDateString()}.";
            return str;
        }
    }
}
