using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace CA_1
{
    class MyDictionary:HashSet<string>
    {
        /// <summary>
        /// Происходили ли изменения
        /// </summary>
        bool _changed;
        /// <summary>
        /// Куда отображаем словарь
        /// </summary>
        TextBox _tb;
        /// <summary>
        /// Файл, с котрым работаем
        /// </summary>
        public string FileName;
        public bool Changed
        {
            get { return _changed; }
            private set
            {
                _changed = value;
                if (_changed)
                    Show();
            }
        }
        /// <summary>
        /// Конструктор для GUI
        /// </summary>
        /// <param name="tb"></param>
        public MyDictionary(TextBox tb)
        {
            this._tb = tb;
            FileName = "";
            _changed = false;
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
        /// Чтение слов из файла
        /// </summary>
        /// <param name="fileName">Имя файла</param>
        /// <returns>true при успешном четении и false в противном случае</returns>
        public bool ReadFromFile(string fileName)
        {
            FileName = fileName;
            this.Clear();
            if (!File.Exists(fileName))
                return false;
            bool error = false;


            //  StreamReader sr = new StreamReader(fileName, Encoding.Default);
            // string text = sr.ReadToEnd();
            string text = File.ReadAllText(fileName);
            char[] separators = {'.', ',','!', '~', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '=', '+', '\\', '|', '/', '?', '.', ',', ';',':', ' ','\n','\r','\t' };
            string [] words=text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                if (IsEnglishWord(word) || IsRussianWord(word))
                    base.Add(word.ToLower());
                else
                    error = true;
          //  sr.Close();

            Changed = false;
            Show();
            return !error;
        }
        /// <summary>
        /// Сохранение в файл
        /// </summary>
        /// <param name="FileName"></param>
        public void SaveToFile(string FileName)
        {
            StreamWriter sw = new StreamWriter(FileName);
            foreach (string word in this)
                sw.WriteLine(word);
            sw.Close();
            Changed = false;
        }
        /// <summary>
        /// Отображение словаря в текстбоксе
        /// </summary>
        /// <param name="tb"></param>
        public void Show()
        {
            _tb.Text = "";
            string text="";
            foreach (string word in this)
                text += word + Environment.NewLine;
            _tb.Text = text;
        }
        /// <summary>
        /// Добавление слова
        /// </summary>
        /// <param name="word">Добавляемое слово</param>
        /// <returns>true, если такого слова не было в словаре и оно было добавлено</returns>
        new public bool Add(string word)
        {
            if (base.Add(word.ToLower()))
            {
                Changed = true;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Удаление слова
        /// </summary>
        /// <param name="word">Добавляемое слово</param>
        /// <returns>true, если слово было удалено</returns>
        new public bool Remove(string word)
        {
            if (base.Remove(word.ToLower()))
            {
                Changed = true;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Очистка словаря
        /// </summary>
        new public void Clear()
        {
            Changed = Count == 0;
            base.Clear();
            Show();
        }
    }
}
