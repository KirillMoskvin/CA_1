using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SAA_2
{
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка, является ли передаваемая строка словом, состоящими из английских букв
        /// </summary>
        /// <param name="word">Передаваемая строка</param>
        /// <returns>true, если является, false в противном случае</returns>
        public static bool IsEnglishWord(string word)
        {
            foreach (char letter in word)
                if (!(letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z'))
                    return false;
            return true;
        }

        /// <summary>
        /// Проверка, является ли передаваемая строка словом, состоящими из английских букв
        /// </summary>
        /// <param name="word">Передаваемая строка</param>
        /// <returns>true, если является, false в противном случае</returns>
        public static bool IsRussianWord(string word)
        {
            foreach (char letter in word)
                if (!(letter >= 'а' && letter <= 'я' || letter >= 'А' && letter <= 'Я'))
                    return false;
            return true;
        }

        /// <summary>
        /// Проверка, является ли передаваяемая строка русским или английским словом
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static bool CheckWord(string word)
        {
            return (IsRussianWord(word) || IsEnglishWord(word));
        }

        /// <summary>
        /// Нажатие кнопки "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ok_Click(object sender, EventArgs e)
        {
            
            tb_input.Text.Trim();
            if (tb_input.Text=="")
            {
                MessageBox.Show("Введите непустое слово!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_input.Focus();
                return;
            }
            if (!CheckWord(tb_input.Text))
            {
                MessageBox.Show("Слово содержит некорректные символы!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_input.Focus();
                return;
            }
            DialogResult = DialogResult.OK;
        }

        //реакция формы на нажатие enter
        private void tb_input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ok.PerformClick();
           //checkletter+служебные
        }

      
        private void tb_input_KeyPress(object sender, KeyPressEventArgs e)
        {
               if (!CheckWord(""+e.KeyChar)&&e.KeyChar!='\b')
                   e.Handled=true;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_input.Clear();
        }
    }
}
