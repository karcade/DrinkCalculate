using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkProduction
{
    class Drink //Класс Напиток
    {
        protected string name; //название напитка
        protected double workPayment; //затраты на оплату труда рабочих за 1 л продукции
        protected double electricEnergyCost; //затраты на электроэнергию

        //Свойство: название напитка
        public string Name
        {
            get { return name; }
        }

        //Свойство: затраты на оплату труда рабочих за 1 л продукции
        public double WorkPayment
        {
            get { return workPayment; }
        }

        //Свойство: затраты на электроэнергию
        public double ElectricEnergyCost
        {
            get { return electricEnergyCost; }
        }

        //Конструктор
        public Drink(string name, double workPayment, double electricEnergyCost)
        {
            this.name = name;
            this.workPayment = workPayment;
            this.electricEnergyCost = electricEnergyCost;
        }

        //Метод: рассчитать стоимость 1 л продукции
        public virtual double Cost()
        {
            double cost = workPayment + electricEnergyCost;
            return cost;
        }

        //Метод: информация об объекте
        public virtual string Info()
        {
            string str = $"\nНазвание: \"{name}\". \nЗатраты на труд: {workPayment} руб." +
                $"\nСтоимость электроэнергии: {electricEnergyCost} руб. \nЦена за л: {Cost()} руб.";
            return str;
        }
    }
}
