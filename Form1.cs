using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrinkProduction
{
    public partial class Form1 : Form
    {
        Drink drink1;
        Juice juice1;
        Wine wine1;
        Kvass kvass1;
        Wine wine2 = new Wine("Merlot", 2, 2, "Мерло", 3);
        Production prod1;
        Production prod2;
        Production prod3;
        Production prod4;
        Production prod5;
        List<Production> recordList = new List<Production>();
        Record record;
        public Form1()
        {
            InitializeComponent();

        }

        private void buttonCreateDrink_Click(object sender, EventArgs e)
        {
            drink1 = new Drink("Золотой ключик", 1, 0.48);
        }

        private void buttonDrinkInfo_Click(object sender, EventArgs e)
        {
            if (drink1!=null)  MessageBox.Show(drink1.Info()); 
            else  MessageBox.Show("Сначала создайте объект, информацию о котором хотите получить"); 
        }

        private void buttonDrinkProduct_Click(object sender, EventArgs e)
        {
            if(drink1!=null)
            {
                if(textBoxDrink.Text != string.Empty)
                { 
                    prod1 = new Production(drink1, DateTime.Now, Convert.ToDateTime("2022,12,4"),
                    Convert.ToDouble(textBoxDrink.Text));
                    recordList.Add(prod1);
                    MessageBox.Show($"Произведено {prod1.Amount} л напитка \"{drink1.Name}\"  стоимостью {prod1.CostProduction()} руб.");
                }
                else MessageBox.Show("Сначала введите необходимое количество литров, а потом уже производите напиток!");
 
            }
             else MessageBox.Show("Сначала создайте напиток, а потом уже его производите!");
            
        }

        private void buttonCreateJuice_Click(object sender, EventArgs e)
        {
            juice1 = new Juice("Добрый",0.7,0.5,35);
        }

        private void buttonJuiceInfo_Click(object sender, EventArgs e)
        {
            if (juice1!=null) MessageBox.Show(juice1.Info()); 
            else MessageBox.Show("Сначала создайте объект, информацию о котором хотите получить"); 
        }

        private void buttonJuiceProduction_Click(object sender, EventArgs e)
        {
            if (juice1 != null)
            {
                if (textBoxJuice.Text != string.Empty)
                {
                    prod2 = new Production(juice1, DateTime.Now, Convert.ToDateTime("2023,11,14"),
                    Convert.ToDouble(textBoxJuice.Text));
                    recordList.Add(prod2);
                    MessageBox.Show($"Произведено {prod2.Amount} л сока \"{juice1.Name}\" " +
                        $"стоимостью {prod2.CostProduction()} руб.");
                }
                else MessageBox.Show("Сначала введите необходимое количество литров, а потом уже производите сок!");
            }
            else
            {
                 MessageBox.Show("Сначала создайте сок, а потом уже его производите!");
            }
        }

        private void buttonCreateKvass_Click(object sender, EventArgs e)
        {
            kvass1 = new Kvass("Хатнi", 0.4,0.3, Kvass.TypeKvass.dark, 0.6);
        }

        private void buttonKvassInfo_Click(object sender, EventArgs e)
        {
            if(kvass1!=null) MessageBox.Show(kvass1.Info());
            else MessageBox.Show("Сначала создайте объект, информацию о котором хотите получить"); 
        }

        private void buttonKvassProduction_Click(object sender, EventArgs e)
        {
            if (kvass1 != null)
            {
                if (textBoxKvass.Text != string.Empty)
                {
                    prod3 = new Production(kvass1, DateTime.Now, Convert.ToDateTime("2024,12,1"),
                    Convert.ToDouble(textBoxKvass.Text));
                    recordList.Add(prod3);
                    MessageBox.Show($"Произведено {prod3.Amount} л кваса \"{kvass1.Name}\" " +
                        $"стоимостью {prod3.CostProduction()} руб.");
                } 
                else MessageBox.Show("Сначала введите необходимое количество литров, а потом уже производите квас!");
            }
            else
            {
                MessageBox.Show("Сначала создайте квас, а потом уже его производите!");
            }
        }

        private void buttonCreateWine_Click(object sender, EventArgs e)
        {
            wine1 = new Wine("Шато Шеваль Бланк",1,1, "Ruby Roman",150);
        }

        private void buttonWineInfo_Click(object sender, EventArgs e)
        {
            if(wine1!=null) MessageBox.Show(wine1.Info()); 
            else MessageBox.Show("Сначала создайте объект, информацию о котором хотите получить"); 
        }

        private void buttonWineProduction_Click(object sender, EventArgs e)
        {
            if (wine1 != null)
            {
                if (textBoxWine.Text != string.Empty)
                {
                    prod4 = new Production(wine1, Convert.ToDateTime("1947,9,11"), Convert.ToDateTime("2024,12,1"),
                    Convert.ToDouble(textBoxWine.Text));
                    recordList.Add(prod4);
                    MessageBox.Show($"Произведено {prod4.Amount} л вина \"{wine1.Name}\" " +
                        $"стоимостью {prod4.CostProduction()} руб.");
                }
                else MessageBox.Show("Сначала введите необходимое количество литров, а потом уже производите вино!");
            }
            else
            {
                MessageBox.Show("Сначала создайте вино, а потом уже его производите!");
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            prod5=new Production(wine2, DateTime.Now, Convert.ToDateTime("2022,12,4"),10);

            record = new Record(recordList);

            //-----Можно раскомментировать эту строку кода для добавление продукции #5 в отчет
            //record.Add(prod5); 

            MessageBox.Show(record.Info());
        }

        private void textBoxDrink_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //цифры, запятая, BackSpace в ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxJuice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //цифры, запятая, BackSpace в ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxKvass_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //цифры, запятая, BackSpace в ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxWine_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            //цифры, запятая, BackSpace в ASCII
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 44 && number != 8)
            {
                e.Handled = true;
            }
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveRecord_Click(object sender, EventArgs e)
        {
            if (record != null)
            {
                FileStream file = new FileStream("Record drink production.txt", FileMode.Create);
                StreamWriter writer = new StreamWriter(file); //сеанс записи файла 
                writer.WriteLine(record.Info());
                writer.Close();
            }
            else MessageBox.Show("Сначало создайте отчет");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
