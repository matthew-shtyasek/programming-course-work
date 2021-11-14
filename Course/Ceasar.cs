using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows.Forms;

namespace Course {
    public partial class ceasarForm : Form {

        public static string alpha;
        public float[] freq;
        public static int dictId;

        public ceasarForm() {
            InitializeComponent();
            alpha = "etaoinshrdlcumwfgypbvkxjqz";
            freq = new float[] {
                0.127f,
                0.0906f,
                0.0817f,
                0.0751f,
                0.0697f,
                0.0675f,
                0.0633f,
                0.0609f,
                0.0599f,
                0.0425f,
                0.0403f,
                0.0278f,
                0.0276f,
                0.0241f,
                0.0236f,
                0.0223f,
                0.0202f,
                0.0197f,
                0.0193f,
                0.0149f,
                0.0098f,
                0.0077f,
                0.0015f,
                0.0015f,
                0.0001f,
                0.00005f
            };
            dictId = 0;
        }

        //==============================ОБРАБОТЧИКИ НАЖАТИЙ НА КНОПКУ==============================

        private void buttonCr_Click(object sender, EventArgs e) { // Шифрование
            string input = inputCr.Text.ToLower();
            int keyshift;
            try {
                keyshift = Convert.ToInt32(inputKeyCr.Text);
            } catch {
                MessageBox.Show("В качестве ключа должно использоваться натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyshift <= 0) {
                MessageBox.Show("В качестве ключа должно использоваться натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            input = input.Replace(" ", "").Replace("\r", "").Replace("\n", "");
            if (dictId == 1) input = input.Replace("ё", "е").Replace("ъ", "ь");
            Console.WriteLine(input);

            if (!testAlpha(input)) {
                MessageBox.Show("Выбран неверный алфавит!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "";

            foreach (char ch in input)
                result += alpha[(alpha.IndexOf(ch) + keyshift) % alpha.Length];
            outputResCr.Text = result;
        }

        private void buttonUCr_Click(object sender, EventArgs e) {
            string input = inputUCr.Text.ToLower();
            int keyshift;
            try {
                keyshift = Convert.ToInt32(inputKeyUCr.Text.ToLower());
            } catch {
                MessageBox.Show("В качестве ключа должно использоваться натуральное число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (keyshift <= 0 || keyshift > alpha.Length) {
                MessageBox.Show("В качестве ключа должно использоваться натуральное число, которое меньше длины алфавита!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!alpha.Contains("" + input[0])) {
                MessageBox.Show("Выбран неверный алфавит!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string result = "";

            foreach (char ch in input) {
                result += alpha[(alpha.IndexOf(ch) - keyshift + alpha.Length) % alpha.Length];
            }
            outputResUCr.Text = result;
        }

        private void hackClick(object sender, EventArgs e) { // Взлом шифра
            if (dictId == -1) {
                MessageBox.Show("Нельзя взломать текст введённый при помощи пользовательского алфавита методом частотного криптоанализа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string input = inputHack.Text.ToLower();
            outputHack.Text = "";

            if (!testAlpha(input)) {
                MessageBox.Show("Выбран неверный алфавит!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<char, float> dict = new Dictionary<char, float>();
            foreach (char ch in alpha) {
                dict.Add(ch, 0f);
            }

            foreach (char ch in input) {
                dict[ch]++;
            }

            foreach (char ch in alpha) {
                dict[ch] /= input.Length;
            }

            //List<char> charList = new List<char>();
            List<float> difList = new List<float>();
            string save = input;
            string result = "";

            try {
                for (int i = 0; i < alpha.Length; i++) {
                    difList.Add(0.0f);
                    for (int j = 0; j < alpha.Length - 10; j++) {
                        char tmp = DictMax(dict);
                        difList[i] += freq[alpha.IndexOf(tmp)] - dict[tmp];
                        //Console.WriteLine($"{tmp} - {dict[tmp]}");
                        dict.Remove(tmp);
                    }
                    foreach (char ch in input) {
                        result += alpha[(alpha.IndexOf(ch) -1 + alpha.Length) % alpha.Length];
                    }
                    input = result;
                    Console.WriteLine(input);
                    result = "";
                    Console.WriteLine(difList[i]);

                    dict.Clear();

                    foreach (char ch in alpha) {
                        dict.Add(ch, 0f);
                    }

                    foreach (char ch in input) {
                        dict[ch]++;
                    }

                    foreach (char ch in alpha) {
                        dict[ch] /= input.Length;
                    }
                }
            } catch {
                MessageBox.Show("Использованы не все символы алфавита!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int minIndex = 0;
            for (int i = 1; i < difList.Count; i++) {
                if (Math.Abs(difList[minIndex]) > Math.Abs(difList[i])) minIndex = i;
            }

            Console.WriteLine(minIndex);

            foreach (char ch in save) {
                result += alpha[(alpha.IndexOf(ch) - minIndex + alpha.Length) % alpha.Length];
            }

            outputHack.Text = result;
            MessageBox.Show($"Ключ равен {minIndex}", "Взлом", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Console.WriteLine("----------------------------------");

            /*for (int i = 0; i < charList.Count; i++) {
                //input = input.Replace(charList[i].ToString(), alpha[i].ToString().ToUpper());
                //Console.WriteLine($"{charList[i]} - {alpha[i].ToString().ToUpper()}");
            }*/

            /*if (dictName != "") {
                if (File.Exists(dictName)) { // Подбор
                    for (int i = 1; i < alpha.Length; i++) {

                        StreamReader reader = new StreamReader(dictName);
                        result = "";
                        int[] counter = { 0, 0 };

                        foreach (char ch in input) {
                            result += alpha[(Array.IndexOf(alpha, ch) - i + alpha.Length) % alpha.Length];
                        }

                        while (!reader.EndOfStream) {
                            if (result.Contains(reader.ReadLine())) counter[1]++;
                            counter[0]++;
                        }

                        if (counter[0] / 4 <= counter[1]) {
                            outputHack.Text = result;
                            MessageBox.Show($"Шифр взломан успешно!\nКлюч: {i}.", "Взлом", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                        reader.Close();
                    }
                } else MessageBox.Show("Словарь отсутствует!");

                if (outputHack.Text == "") MessageBox.Show("Шифр не удалось взломать. Это может быть вызвано следующими причинами:\n" +
                                                            "\t- Используется не тот алфавит\n" +
                                                            "\t- Текст не содержит слов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                MessageBox.Show("Невозможно взломать текст, для шифровки которого использовался пользовательский алфавит!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        //============================================================================================================

        //=====================================ОБРАБОТЧИКИ НАЖАТИЯ НА ПУНКТ МЕНЮ=========================================

        //----------------------------------------Опции---------------------------------------

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e) {
            alpha = "etaoinshrdlcumwfgypbvkxjqz";
            freq = new float[] {
                0.127f,
                0.0906f,
                0.0817f,
                0.0751f,
                0.0697f,
                0.0675f,
                0.0633f,
                0.0609f,
                0.0599f,
                0.0425f,
                0.0403f,
                0.0278f,
                0.0276f,
                0.0241f,
                0.0236f,
                0.0223f,
                0.0202f,
                0.0197f,
                0.0193f,
                0.0149f,
                0.0098f,
                0.0077f,
                0.0015f,
                0.0015f,
                0.0001f,
                0.00005f
            };
            dictId = 0;
            английскийToolStripMenuItem.Checked = true;
            русскийToolStripMenuItem.Checked = false;
            свойToolStripMenuItem.Checked = false;
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e) {
            alpha = "оеаитнсрвлкмдпуяызьбгчйхжюшцщэф";
            freq = new float[] {
                0.09f,
                0.072f,
                0.062f,
                0.062f,
                0.053f,
                0.053f,
                0.045f,
                0.040f,
                0.038f,
                0.035f,
                0.028f,
                0.026f,
                0.025f,
                0.023f,
                0.021f,
                0.018f,
                0.016f,
                0.016f,
                0.014f,
                0.014f,
                0.013f,
                0.012f,
                0.010f,
                0.009f,
                0.007f,
                0.006f,
                0.006f,
                0.004f,
                0.003f,
                0.003f,
                0.002f
            };
            dictId = 1;
            английскийToolStripMenuItem.Checked = false;
            русскийToolStripMenuItem.Checked = true;
            свойToolStripMenuItem.Checked = false;
        }

        private void свойToolStripMenuItem_Click(object sender, EventArgs e) {
            английскийToolStripMenuItem.Checked = false;
            русскийToolStripMenuItem.Checked = false;
            свойToolStripMenuItem.Checked = true;
            new inputAlph().ShowDialog();
        }

        private void поУмолчаниюToolStripMenuItem_Click(object sender, EventArgs e) {
            alpha = "etaoinshrdlcumwfgypbvkxjqz";
            freq = new float[] {
                0.127f,
                0.0906f,
                0.0817f,
                0.0751f,
                0.0697f,
                0.0675f,
                0.0633f,
                0.0609f,
                0.0599f,
                0.0425f,
                0.0403f,
                0.0278f,
                0.0276f,
                0.0241f,
                0.0236f,
                0.0223f,
                0.0202f,
                0.0197f,
                0.0193f,
                0.0149f,
                0.0098f,
                0.0077f,
                0.0015f,
                0.0015f,
                0.0001f,
                0.00005f
            };
            dictId = 0;
            английскийToolStripMenuItem.Checked = true;
            русскийToolStripMenuItem.Checked = false;
            свойToolStripMenuItem.Checked = false;
        }

        private void enableBtn(Button btn, TextBox txt1, TextBox txt2) {
            btn.Enabled = txt1.TextLength > 0 && txt2.TextLength > 0;
        }

        private void messageChanged(object sender, EventArgs e) {
            enableBtn(buttonCr, inputCr, inputKeyCr);
        }

        private void keyChanged(object sender, EventArgs e) {
            enableBtn(buttonCr, inputCr, inputKeyCr);
        }

        private void cipherChanged(object sender, EventArgs e) {
            enableBtn(buttonUCr, inputUCr, inputKeyUCr);
        }

        private void key2Changed(object sender, EventArgs e) {
            enableBtn(buttonUCr, inputUCr, inputKeyUCr);
        }

        private void hackChanged(object sender, EventArgs e) {
            buttonHack.Enabled = Convert.ToBoolean(inputHack.Text.Length);
        }

        private void inputUCr_TextChanged(object sender, EventArgs e) {
            enableBtn(buttonUCr, inputUCr, inputKeyUCr);
        }

        private char DictMax(Dictionary<char, float> dict) {
            char sym = ' ';
            float tmp = 0.0f;
            foreach (char ch in dict.Keys) {
                if (tmp < dict[ch]) {
                    tmp = dict[ch];
                    sym = ch;
                }
            }
            return sym;
        }

        private bool testAlpha(string str) {
            foreach (char ch in new HashSet<char>(str)) {
                if (!alpha.Contains("" + ch)) {
                    Console.WriteLine(ch);
                    return false;
                }
            }
            return true;
        }
    }
}