using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkProduction
{
    class Juice:Drink //Класс Сок
    {
        double content; //содержание сока прямого отжима

        //Свойство: содержание сока прямого отжима
        public double Content
        {
            get { return content; }
        }

        //Конструктор
        public Juice(string name,  double workPayment, double electricEnergyCost, 
            double content)
            : base(name, workPayment, electricEnergyCost)
        {
            this.content = content;
        }

        //Метод: стоимость 1 л сока
        public override double Cost()
        {
            double cost; //стоимость

            cost = workPayment + electricEnergyCost;

            if (content > 0 && content <= 25) cost += cost * 0.2; //сокосодержащий напиток (менее 25%)
            else
            {
                if (content > 25 && content <= 50) cost += cost * 0.5; //нектар (25-50%)
                else 
                { 
                        if (content > 50 && content <= 100) cost += cost * 0.8; //сок(50-100%)
                        else cost = 0;
                }
            }
            return Math.Round(cost, 2);
        }

        //Метод: информация о соке
        public override string Info()
        {
            string str = $"\nСок.\nНазвание: \"{name}\". \nЗатраты на труд: {workPayment} руб." +
                $"\nСтоимость электроэнергии: {electricEnergyCost} руб." +
                $"\nСодержание сока: {content}%. Цена за л: {Cost()} руб.";
            return str;
        }
    }
}
