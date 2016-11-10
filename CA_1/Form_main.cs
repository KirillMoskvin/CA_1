using System;
using System.Windows.Forms;
using System.Collections.Generic;
using SAA_2;

namespace CA_1
{
    public partial class Lab1_5a : Form
    {
        MyDictionary dict;
        InputBox input;
        public Lab1_5a()
        {
            InitializeComponent();
            dict = new MyDictionary(tb_input);
            input = new InputBox();
        }

        #region Вспомогательные функции
        /// <summary>
        /// Запрашивает у пользователя диалоговое окно на ввод слова
        /// </summary>
        /// <returns>Слово</returns>
        string GetWord()
        {
            if (input.ShowDialog() == DialogResult.OK)
            {
                string wrd = input.tb_input.Text;
                input.tb_input.Clear();
                return wrd;
            }
            input.tb_input.Clear();
            return "";
        }
      
        #endregion
        #region Файл
        /// <summary>
        /// Открытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog()==DialogResult.OK)
            {
                dict.ReadFromFile(openFileDialog.FileName);
            }
        }
        /// <summary>
        /// "Сохранить как"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsb_saveas_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                dict.SaveToFile(saveFileDialog.FileName);
                if (dict.FileName == "")
                    dict.FileName = saveFileDialog.FileName;
            }
        }
        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab1_5a_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        #endregion
        #region Выполнить
        /// <summary>
        /// Выполнение условия задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string wrd="";
            if (input.ShowDialog() == DialogResult.OK)
            {
                wrd = input.tb_input.Text;
                input.tb_input.Clear();
                List<string> words = new List<string>();
                MessageBox.Show(GetSolution.CountAllAssignedWords(wrd, dict, ref words).ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tb_output.Clear();
                foreach (string str in words)
                    tb_output.Text += str + "\r\n";
            }
        }
        

        #endregion
        #region Правка
        /// <summary>
        /// Добавление слова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string word = GetWord();
            if (!dict.Add(word))
                MessageBox.Show("Запрашиваемое слово уже существует в словаре", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        /// <summary>
        /// Удаление слова
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteСловоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string word = GetWord();
            if (!dict.Remove(word))
                MessageBox.Show("Запрашиваемое слово не найдено в словаре", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        /// <summary>
        /// Очистка словаря
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                dict.Clear();
        }
        #endregion
        #region Помощь
        /// <summary>
        /// Условие задачи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskToDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Даны слово и словарь, представляющий собой набор слов. Необходимо посчитать количество слов в словаре" +
                ", которые можно составить из букв исходного слова\n\r\n\rВыполнил Москвин Кирилл, 3 курс, 9 группа",
                "Условие", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Выполнить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Москвин Кирилл, 3 курс, 9 группа", "Выполнил", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}
