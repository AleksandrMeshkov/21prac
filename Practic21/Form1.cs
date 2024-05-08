using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practic21
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("По алфавиту");
            comboBox1.Items.Add("По цифрам");
            comboBox2.Items.Add("По алфавиту");
            comboBox2.Items.Add("По цифрам");
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Razdel2.Items.Count; i++)
            {
                Razdel1.Items.Add(Razdel2.Items[i]);
                Razdel2.Items.RemoveAt(i);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Razdel1.Items.Count; i++)
            {
                Razdel2.Items.Add(Razdel1.Items[i]);
                Razdel1.Items.RemoveAt(i);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string lastItem = Razdel2.Items[Razdel2.Items.Count - 1].ToString();
            Razdel1.Items.Add(lastItem);
            Razdel2.Items.RemoveAt(Razdel2.Items.Count - 1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastItem = Razdel1.Items[Razdel1.Items.Count - 1].ToString();
            Razdel2.Items.Add(lastItem);
            Razdel1.Items.RemoveAt(Razdel1.Items.Count - 1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        public void Razdel2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void Razdel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Razdel2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Razdel1.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Razdel1.Items.Clear();
            Razdel2.Items.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            Razdel1.Items.Clear();
            Razdel2.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string selectedSortMode = comboBox1.SelectedItem.ToString();
            if (selectedSortMode == "По алфавиту")
            {
                Razdel1.Sorted = true;
            }
            else
            {
                Razdel2.Sorted = false;
            }
            if (selectedSortMode == "По цифрам")
            {
                Razdel1.Sorted = true;
            }
            else
            {
                Razdel2.Sorted = false;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string selectedSortMode = comboBox1.SelectedItem.ToString();
            if (selectedSortMode == "По алфавиту")
            {
                Razdel2.Sorted = true;
            }
            else
            {
                Razdel1.Sorted = false; 
            }
            if (selectedSortMode == "По цифрам")
            {
                Razdel2.Sorted = true;
            }
            else
            {
                Razdel1.Sorted = false;
            }


       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string searchTerm = listBox1.Text; // Получаем текст для поиска
            SearchListBox(searchTerm); // Вызываем функцию поиска
        }
        private void SearchListBox(string searchTerm)
        {
            // Проходим по элементам ListBox и ищем совпадения
            for (int i = 1; i < Razdel1.Items.Count; i++)
            {
                if (Razdel1.Items[i].ToString().Contains(searchTerm))
                {
                    // Найдено совпадение - выделяем элемент
                    Razdel1.SetSelected(i, true);
                    listBox1.Items.Add(Razdel1.Items[i]);


                    // Можно добавить дополнительные действия при нахождении совпадения
                }
            }
        }
    }
}
