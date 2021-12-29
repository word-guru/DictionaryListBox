using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryListBox
{
    
    public partial class Form1 : Form
    {
        Dictionary<string, int> student = new Dictionary<string, int>
        {
            {"Петр Петров",7},
            {"Иван Иванов",12},
            {"Семен Семенов",5},
            {"Вася Васильев",7},
            {"Артем Артемов",11},
            {"Андрей Андреев",8},
            {"Стас Стасов",10},
            {"Денис Денисов",9},
            {"Федя Федотов",12},
        };
        public Form1()
        {
            InitializeComponent();

            foreach (var item in student)
            {
                checkedListBox1.Items.Add(item.Key);
            }
            checkedListBox1.CheckOnClick = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = checkedListBox1.CheckedItems.Count;
            int averaging = 0;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                foreach (var s in student)
                {
                    if(item == s.Key)
                        averaging+=s.Value;
                }
            }
            MessageBox.Show($"Средняя оценка выбранных студентов: {averaging/i}");
        }
    }
}
