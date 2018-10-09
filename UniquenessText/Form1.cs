using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UniquenessText
{
    public partial class Form : System.Windows.Forms.Form
    {
        static readonly Dictionary<char, char> ConvertChar =
            new Dictionary<char, char>
            {
                {'а', 'a'},
                {'А', 'A'},
                {'у', 'y'},
                {'К', 'K'},
                {'е', 'e'},         // первое значение - русский символ
                {'Е', 'E'},         //
                {'Н', 'H'},         // второе - английский
                {'О', 'O'},         //
                {'о', 'o'},
                {'Х', 'X'},
                {'х', 'x'},
                {'В', 'B'},
                {'р', 'p'},
                {'Р', 'P'},
                {'с', 'c'},
                {'С', 'C'},
                {'M', 'M'},
                {'T', 'T'},
            };

        public Form()
        {
            InitializeComponent();
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                foreach (var charPair in ConvertChar)
                {
                    textBox.Text = textBox.Text.Replace(charPair.Key, charPair.Value);
                }
            }
            else if (radioButton2.Checked == true)
            {
                foreach (var charPair in ConvertChar)
                {
                    textBox.Text = textBox.Text.Replace(charPair.Value, charPair.Key);
                }
            }
            else
            {
                MessageBox.Show("Выберите тип замены!", "Ошбика!");
            }
        }
    }
}
