using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrinkProduction
{
    class Record
    {
        List<Production> recordList = new List<Production>(); //список произведенной продукции

        //Контруктор
        public Record(List<Production> recordList)
        {
            this.recordList = recordList;
        }

        //Свойство: список произведенной продукции
        public List<Production> RecordList
        {
            get { return recordList; }
        }

        //Метод: отчет о произведенной продукции
        public string Info()
        {
            string str = "\n    Отчёт о произведенной продукции \n";
            foreach (Production prod in recordList)
                str = str + prod.Info() + "\n";
            return str;
        }

        //Метод: добавить произведенную продукцию в список
        public void Add(Production pr)
        {
            recordList.Add(pr);
        }

    }
}
