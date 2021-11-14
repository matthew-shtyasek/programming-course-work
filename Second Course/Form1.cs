using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Form1 : Form
    {
        private string vowels = "аеёиоуыэюя";
        private string consonants = "бвгджзйклмнпрстфхцчшщъь";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            string str = textBox1.Text;
            int len;
            try
            {
                len = Convert.ToInt32(textBoxNum.Text);
            }
            catch
            {
                MessageBox.Show("Вы не ввели количество символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (len <= 2)
            {
                MessageBox.Show("Вы ввели неверное количество символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 1; str.Length > len; i++)
            {
                string[] words = str.Split(' ');
                int[] countwords = countWords(str, len);
                if (words[countwords[0]].Length <= 3)
                {
                    string tmp = str.Substring(0, countwords[2] - countwords[1] + words[countwords[0]].Length + 1);
                    tmp = tmp.Trim(' ');
                    if (tmp.Length > len)
                    {
                        tmp = tmp.Substring(0, tmp.Length - words[countwords[0]].Length);
                        textBox2.Text += tmp + "\r\n";
                        str = str.Substring(/*countwords[2] - countwords[1] + */tmp.Length).Trim(' ');
                    } else {
                        textBox2.Text += tmp + "\r\n";
                        str = str.Substring(countwords[2] - countwords[1] + words[countwords[0]].Length).Trim(' ');
                    }
                    //str = str.Substring(countwords[2] - countwords[1] + words[countwords[0]].Length);
                    continue;
                }

                if (countwords[0] == 0 && words[countwords[0]].Length <= len) //Если только одно слово, которое не нужно переносить
                { 
                    textBox2.Text += words[countwords[0]] + "\r\n";
                    str = str.Substring(words[countwords[0]].Length).Trim(' ');
                    continue;
                }

                if (countwords[1] <= 2) //Если перенос выпал на начало слова
                {
                    textBox2.Text += str.Substring(0, str.IndexOf(words[countwords[0]]) - 1) + "\r\n";
                    str = str.Substring(str.IndexOf(words[countwords[0]]) - 1).Trim(' ');
                    continue;
                }

                int absPosition = hyphenation(words[countwords[0]], countwords[1], countwords[2]); //Абсолютная позиция переноса
                if (absPosition + 1 > len && countwords[0] == 0) //Если слово больше заданной длины
                {
                    textBox2.Text += str.Substring(0, absPosition + 1) + "-\r\n";
                    str = str.Substring(absPosition + 1).Trim(' ');
                    continue;
                }
                else if (absPosition + 1 > len && words[countwords[0]].Length > len) //
                {
                    textBox2.Text += str.Substring(0, countwords[2] - countwords[1]) + "\r\n";
                    str = str.Substring(countwords[2] - countwords[1]).Trim(' ');
                    continue;
                }

                if (absPosition + 1 != countwords[2] - countwords[1] + words[countwords[0]].Length)
                {
                    absPosition += countwords[0];
                    if (str.Length == len)
                    {
                        textBox2.Text += str + "\r\n";
                        absPosition = str.Length - 1;
                    }
                    else
                    {
                        try {
                            if (consonants.Contains(str[absPosition]) && vowels.Contains(str[absPosition + 1])) absPosition--;
                        }
                        catch
                        {

                        }
                        if (str[absPosition] == ' ' || absPosition == str.Length - 1 || (absPosition < str.Length && str[absPosition + 1] == ' ')) textBox2.Text += str.Substring(0, absPosition + 1) + "\r\n";
                        else textBox2.Text += str.Substring(0, absPosition + 1) + "-\r\n";
                    }
                }
                else
                {
                    absPosition += countwords[0];
                    textBox2.Text += str.Substring(0, absPosition + 1) + "\r\n";
                }
                str = str.Substring(absPosition + 1).Trim(' ');
            }
            if (str != "") {
                textBox2.Text += str.Trim(' ');
            }
        }

        private int[] countWords(string str, int pos) //count - 1
        {
            int count = 0, countSym = 1, absCountSym = 1;
            for (int i = 1; i < pos && i < str.Length; i++)
            {
                if (str[i-1] == ' ')
                {
                    count++;
                    countSym = 0;
                }
                countSym++;
                absCountSym++;
            }
            int[] arr = { count, countSym - 1, absCountSym - 1 };
            return arr;
        }

        private int hyphenation(string str, int pos, int len)
        {
            List<int> list1 = new List<int>(); //Список для хранения всех возможных позиций переноса в первом случае
            List<int> list2 = new List<int>(); //Список для хранения всех возможных позиций переноса во втором случае
            //Идея заключается в том, что нам нужно по листу для каждого типа переноса, куда мы запишем в итоге какой символ (i) удалось перенести 
            for (int i = 2; i < str.Length - 1; i++) //Нам нужен максимум предпоследний символ
            {
                if (vowels.Contains(str[i]) && vowels.Contains(str[i - 1])) //Если предыдущая является гласной
                {
                    if (consonants.Contains(str[i - 2]) && (Char.ToLower(str[i + 1]) != 'й' || i + 1 != str.Length - 1) && (consonants.Contains(str[i + 1]) || vowels.Contains(str[i + 1])))
                    {
                        list1.Add(i);
                    }
                }

                if (consonants.Contains(str[i]) && consonants.Contains(str[i - 1])) //Если предыдущая является согласной
                {
                    if (vowels.Contains(str[i - 2]) && hasVowel(str.Substring(i+1)))
                    {
                        list2.Add(i);
                    }
                }
            }

            if (list1.Count == 0 && list2.Count == 0)
            {
                for (int i = 1; i < str.Length - 1; i++)
                {
                    if (vowels.Contains(str[i]) && consonants.Contains(str[i + 1]) && (consonants.Contains(str[i - 1]) || vowels.Contains(str[i-1])) && hasVowel(str.Substring(i + 2))) 
                    {
                        list1.Add(i);
                    }
                }
            }

            int min1 = minListDif(list1, pos, str.Length - 1);
            int min2 = minListDif(list2, pos, str.Length - 1);

            if (min1 > min2) min1 = min2;
            if (min1 > len) return min1;
            return len - min1;
        }

        private bool hasVowel(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.Contains(str[i])) return true;
            }
            return false;
        }

        private int minListDif(List<int> list, int num, int len)
        {
            int min = len;
            for (int i = 0; i < list.Count; i++)
            {
                int temp = num - list[i];
                if (temp < 0) continue;
                if (temp < min) min = temp;
            }
            return min;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = Convert.ToBoolean(textBox1.Text.Length) && Convert.ToBoolean(textBoxNum.Text.Length);
        }

        private void textBoxNum_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = Convert.ToBoolean(textBox1.Text.Length) && Convert.ToBoolean(textBoxNum.Text.Length);
        }
    }
}
