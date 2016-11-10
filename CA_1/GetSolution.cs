using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_1
{
    class GetSolution
    {
        /// <summary>
        /// Подсчет всех подходящих слов, которые могут получиться из букв заданного
        /// </summary>
        /// <param name="word">Слово</param>
        /// <returns>Количество таких слов</returns>
        public static int CountAllAssignedWords(string word, MyDictionary dict, ref List<string> words)
        {
            // string dev = word+Environment.NewLine;
            int res = 0;
            char[] sortedLetters = word.ToLower().ToCharArray();
            Array.Sort(sortedLetters);
            for (int i = 1; i <= word.Length; ++i)
            {
                Array.Sort(sortedLetters);
                string assign = ArrToStr(ref sortedLetters, i);
                if (dict.Contains(assign))
                {
                    ++res;
                    words.Add(assign);
                }
                // dev += Environment.NewLine + assign;

                do
                {
                    assign = GetNextLex(ref sortedLetters, i, sortedLetters.Length);
                    //   dev += Environment.NewLine + assign;
                    if (dict.Contains(assign))
                    {
                        ++res;
                        words.Add(assign);
                    }
                } while (assign != "");
            }

            return res;
        }
        /// <summary>
        /// Получение следующего в лексикографическом порядке размещения из N элементов по M
        /// </summary>
        /// <param name="letters">Набор элементов</param>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <returns>Слово-перстановку, либо пустую строку, если перестановка последняя</returns>
        static string GetNextLex(ref char[] letters, int M, int N)
        {
            for (int i = M - 1; i >= 0; --i)
            {
                for (int j = M; j < N; ++j)
                    if (letters[j] > letters[i]) //просматриваем "свободные элементы"
                    {
                        Swap(ref letters[i], ref letters[j]);
                        Sort(ref letters, i + 1);
                        return ArrToStr(ref letters, M);
                    }
                for (int j = M - 1; j > i; --j) //если такие кончились, смотрим остальные
                    if (letters[j] > letters[i])
                    {
                        Swap(ref letters[i], ref letters[j]); //меняем местами данный элементы и первый, который больше него
                        Sort(ref letters, i + 1); //сортируем остаток размещения
                        return ArrToStr(ref letters, M);
                    }
            }
            return "";
        }
        /// <summary>
        /// Конвертация нужной части перестановки в строку
        /// </summary>
        /// <param name="letters">Массив символов</param>
        /// <param name="m">До какого элемента конвертируем</param>
        /// <returns>Часть массива до N-го элемента в виде строки</returns>
        static string ArrToStr(ref char[] letters, int m)
        {
            string res = "";
            for (int i = 0; i < m; ++i)
                res += letters[i];
            return res;
        }
        /// <summary>
        /// Сортировка "хвоста" перестановки
        /// </summary>
        /// <param name="letters">Переставляемый массив символов</param>
        /// <param name="v">Начало "хвоста"</param>
        static void Sort(ref char[] letters, int v)
        {
            int last = letters.Length - 1;
            do
            {
                int end = last;
                last = -1;
                for (int i = v; i < end; ++i)
                    if (letters[i] > letters[i + 1])
                    {
                        Swap(ref letters[i], ref letters[i + 1]);
                        last = i;
                    }
            } while (last != -1);
        }
        /// <summary>
        /// Обмен двух значений местами
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        static void Swap(ref char v1, ref char v2)
        {
            char tmp = v1;
            v1 = v2;
            v2 = tmp;
        }
    }
}
