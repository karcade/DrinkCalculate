using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkProduction
{
    class Kvass : Drink
    {
        double rawCost; //стоимость сырья
        TypeKvass type; //тип класса: темный, светлый

        public enum TypeKvass
        {
            light,
            dark
        }

        //Свойство: вид кваса
        public TypeKvass Type
        {
            get { return type; }
            set { Type = value; }
        }

        //Свойство: стоимость сырья
        public double RawCost
        {
            get { return rawCost; }
        }

        //Конструктор
        public Kvass(string name,  double workPayment, double electricEnergyCost,
             TypeKvass type, double rawCost)
            : base(name,  workPayment, electricEnergyCost)
        {
            this.type = type;
            this.rawCost = rawCost;
        }

        //Метод: стоимость 1 литра кваса
        public override double Cost()
        {
            double cost;
            
            cost = workPayment + electricEnergyCost + rawCost;

            if (DateTime.Now.Month >= 6 && DateTime.Now.Month <= 8) cost = cost * 1.5;

            if (type == TypeKvass.dark) cost = cost * 1.25;
            else if (type != TypeKvass.light) cost = 0;
            
            return Math.Round(cost, 2); 
        }

        //Метод: информация о квасе
        public override string Info()
        {
            string str = $"\nКвас.\nНазвание: \"{name}\". \nЗатраты на труд: {workPayment} руб." +
                $"\nСтоимость электроэнергии: {electricEnergyCost} руб." +
                $"\nТип кваса: {type}. Цена за л: {Cost()} руб.";
            return str;
        }
    }
}
