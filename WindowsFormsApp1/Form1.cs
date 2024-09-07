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

            fromSysNumberTextBox.Text = string.Empty;
            int n = Convert.ToInt32(fromSysNumericUpDown.Value);

            tPanel.Controls.Clear();
            tPanel.ColumnCount = Math.Min(10, n);
            tPanel.RowCount = (int)(Math.Ceiling(n / 10.0));
            tPanel.Size = new System.Drawing.Size(tPanel.ColumnCount * 60, tPanel.RowCount * 40);

            List<Button> buttons = new List<Button>();

            for (int i = 0; i < n; i++)
            {
                buttons.Add(new Button());
                buttons[i].BackColor = Color.Blue;
                buttons[i].ForeColor = Color.White;
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
            if (fromSysNumberTextBox.Text == string.Empty && IsZero(sender))
                return;

            string text = ((Button)sender).Text;
            fromSysNumberTextBox.Text += text;
        }

        private bool IsZero(object sender) =>
            ((Button)sender).Text == "0";

        private void fromClearButton_Click(object sender, EventArgs e) =>
            fromSysNumberTextBox.Text = string.Empty;

        private void toSysClearButton_Click(object sender, EventArgs e) =>
            toSysNumberTextBox.Text = string.Empty;
        
        private void toSysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            //1. получаем число, поулчаем основания систем откуда/куда
            //2. вызываем методы для конвертации
            //3. кладем результат методов в текстовое поле 

            if (fromSysNumberTextBox.Text == string.Empty)
                return;

            string text = fromSysNumberTextBox.Text;
            int fromN = Convert.ToInt32(fromSysNumericUpDown.Value);
            int toN = Convert.ToInt32(toSysNumericUpDown.Value);
            string result = Converter.From10(Converter.To10(text, fromN), toN);
            toSysNumberTextBox.Text = result;
        }

        private void fromSysClearLastButton_Click(object sender, EventArgs e)
        {
            if (fromSysNumberTextBox.Text == string.Empty)
                return;

            string text = fromSysNumberTextBox.Text;
            fromSysNumberTextBox.Text = text.Substring(0, text.Length - 1);
        }

        private void toSysClearLastButton_Click(object sender, EventArgs e)
        {
            if (toSysNumberTextBox.Text == string.Empty)
                return;

            string text = toSysNumberTextBox.Text;
            toSysNumberTextBox.Text = text.Substring(0, text.Length - 1);
        }
    }
}
