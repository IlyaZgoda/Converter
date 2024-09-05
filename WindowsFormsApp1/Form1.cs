using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // доделать 1. не позволять начинать число с нуля 2. сделать очистку последнего символа 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fromSysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //1. получаем систему счистления
            //2. нстраиваем tableLayoutpanel под нужные размеры
            //3. формируем список кнопок - цифры
            //4. отображаем кнопки на tPanel по ячейкам
            //5. привязываем к кнопкам событие onClck

            numberTextBox.Text = string.Empty;
            int n = Convert.ToInt32(fromSysNumericUpDown.Value);

            tPanel.Controls.Clear();
            tPanel.ColumnCount = Math.Min(10, n);
            tPanel.RowCount = (int)(Math.Ceiling(n / 10.0));
            tPanel.Size = new System.Drawing.Size(tPanel.ColumnCount * 60, tPanel.RowCount * 40);

            List<Button> buttons = new List<Button>();

            for (int i = 0; i < n; i++)
            {
                buttons.Add(new Button());
                buttons[i].BackColor = Color.Gray;
                buttons[i].Size = new System.Drawing.Size(50,30);
                
                if (i < 10)
                    buttons[i].Text = $"{i}";

                else
                    buttons[i].Text = $"{(char)('A' + i - 10)}";

                buttons[i].Click += clickButtons;
                tPanel.Controls.Add(buttons[i], i % 10, i / 10);

            }
        }

        private void clickButtons(object sender, EventArgs e)
        {
            string t = ((Button)sender).Text;
            numberTextBox.Text += t;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Text = string.Empty;
        }

        private void toSysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //1. получаем число, поулчаем основания систем откуда/куда
            //2. вызываем методы для конвертации
            //3. кладем результат методов в текстовое поле 

            if (numberTextBox.Text == string.Empty)
                return;

            string a = numberTextBox.Text;
            int fromN = Convert.ToInt32(fromSysNumericUpDown.Value);
            int toN = Convert.ToInt32(toSysNumericUpDown.Value);
            string result = Converter.From10(Converter.To10(a, fromN), toN);
            numberTextBox2.Text = result;
        }
    }
}
