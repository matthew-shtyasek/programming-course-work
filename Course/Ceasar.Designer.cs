
using System;

namespace Course {
    partial class ceasarForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCloseCr = new System.Windows.Forms.Button();
            this.buttonCr = new System.Windows.Forms.Button();
            this.outputResCr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputKeyCr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputCr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outputResUCr = new System.Windows.Forms.TextBox();
            this.inputUCr = new System.Windows.Forms.TextBox();
            this.buttonCloseUCr = new System.Windows.Forms.Button();
            this.buttonUCr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.inputKeyUCr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonCloseHack = new System.Windows.Forms.Button();
            this.buttonHack = new System.Windows.Forms.Button();
            this.outputHack = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inputHack = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.языкАлфавитаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.русскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.английскийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поУмолчаниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(9, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 431);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonCloseCr);
            this.tabPage1.Controls.Add(this.buttonCr);
            this.tabPage1.Controls.Add(this.outputResCr);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.inputKeyCr);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.inputCr);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Зашифровать";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonCloseCr
            // 
            this.buttonCloseCr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseCr.Location = new System.Drawing.Point(492, 356);
            this.buttonCloseCr.Name = "buttonCloseCr";
            this.buttonCloseCr.Size = new System.Drawing.Size(145, 37);
            this.buttonCloseCr.TabIndex = 4;
            this.buttonCloseCr.Text = "Закрыть";
            this.buttonCloseCr.UseVisualStyleBackColor = true;
            this.buttonCloseCr.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCr
            // 
            this.buttonCr.Enabled = false;
            this.buttonCr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCr.Location = new System.Drawing.Point(341, 356);
            this.buttonCr.Name = "buttonCr";
            this.buttonCr.Size = new System.Drawing.Size(145, 37);
            this.buttonCr.TabIndex = 3;
            this.buttonCr.Text = "Зашифровать";
            this.buttonCr.UseVisualStyleBackColor = true;
            this.buttonCr.Click += new System.EventHandler(this.buttonCr_Click);
            // 
            // outputResCr
            // 
            this.outputResCr.Location = new System.Drawing.Point(8, 244);
            this.outputResCr.Multiline = true;
            this.outputResCr.Name = "outputResCr";
            this.outputResCr.ReadOnly = true;
            this.outputResCr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputResCr.Size = new System.Drawing.Size(629, 99);
            this.outputResCr.TabIndex = 2;
            this.outputResCr.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Результат:";
            // 
            // inputKeyCr
            // 
            this.inputKeyCr.Location = new System.Drawing.Point(8, 175);
            this.inputKeyCr.Name = "inputKeyCr";
            this.inputKeyCr.Size = new System.Drawing.Size(629, 26);
            this.inputKeyCr.TabIndex = 1;
            this.inputKeyCr.TextChanged += new System.EventHandler(this.keyChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите ключ в поле ниже:";
            // 
            // inputCr
            // 
            this.inputCr.Location = new System.Drawing.Point(8, 38);
            this.inputCr.Multiline = true;
            this.inputCr.Name = "inputCr";
            this.inputCr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputCr.Size = new System.Drawing.Size(629, 93);
            this.inputCr.TabIndex = 0;
            this.inputCr.TextChanged += new System.EventHandler(this.messageChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите текст сообщения в поле ниже:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outputResUCr);
            this.tabPage2.Controls.Add(this.inputUCr);
            this.tabPage2.Controls.Add(this.buttonCloseUCr);
            this.tabPage2.Controls.Add(this.buttonUCr);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.inputKeyUCr);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Расшифровать";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outputResUCr
            // 
            this.outputResUCr.Location = new System.Drawing.Point(8, 244);
            this.outputResUCr.Multiline = true;
            this.outputResUCr.Name = "outputResUCr";
            this.outputResUCr.ReadOnly = true;
            this.outputResUCr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputResUCr.Size = new System.Drawing.Size(629, 99);
            this.outputResUCr.TabIndex = 22;
            // 
            // inputUCr
            // 
            this.inputUCr.Location = new System.Drawing.Point(8, 38);
            this.inputUCr.Multiline = true;
            this.inputUCr.Name = "inputUCr";
            this.inputUCr.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputUCr.Size = new System.Drawing.Size(629, 93);
            this.inputUCr.TabIndex = 21;
            this.inputUCr.TextChanged += new System.EventHandler(this.inputUCr_TextChanged);
            // 
            // buttonCloseUCr
            // 
            this.buttonCloseUCr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseUCr.Location = new System.Drawing.Point(492, 356);
            this.buttonCloseUCr.Name = "buttonCloseUCr";
            this.buttonCloseUCr.Size = new System.Drawing.Size(145, 37);
            this.buttonCloseUCr.TabIndex = 4;
            this.buttonCloseUCr.Text = "Закрыть";
            this.buttonCloseUCr.UseVisualStyleBackColor = true;
            this.buttonCloseUCr.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonUCr
            // 
            this.buttonUCr.Enabled = false;
            this.buttonUCr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUCr.Location = new System.Drawing.Point(341, 356);
            this.buttonUCr.Name = "buttonUCr";
            this.buttonUCr.Size = new System.Drawing.Size(145, 37);
            this.buttonUCr.TabIndex = 3;
            this.buttonUCr.Text = "Расшифровать";
            this.buttonUCr.UseVisualStyleBackColor = true;
            this.buttonUCr.Click += new System.EventHandler(this.buttonUCr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 20;
            this.label4.Text = "Результат:";
            // 
            // inputKeyUCr
            // 
            this.inputKeyUCr.Location = new System.Drawing.Point(8, 175);
            this.inputKeyUCr.Name = "inputKeyUCr";
            this.inputKeyUCr.Size = new System.Drawing.Size(629, 26);
            this.inputKeyUCr.TabIndex = 1;
            this.inputKeyUCr.TextChanged += new System.EventHandler(this.key2Changed);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(265, 26);
            this.label5.TabIndex = 19;
            this.label5.Text = "Введите ключ в поле ниже:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(420, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Введите зашифрованный текст в поле ниже:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonCloseHack);
            this.tabPage3.Controls.Add(this.buttonHack);
            this.tabPage3.Controls.Add(this.outputHack);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.inputHack);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(640, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Взломать";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonCloseHack
            // 
            this.buttonCloseHack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseHack.Location = new System.Drawing.Point(492, 356);
            this.buttonCloseHack.Name = "buttonCloseHack";
            this.buttonCloseHack.Size = new System.Drawing.Size(145, 37);
            this.buttonCloseHack.TabIndex = 3;
            this.buttonCloseHack.Text = "Закрыть";
            this.buttonCloseHack.UseVisualStyleBackColor = true;
            this.buttonCloseHack.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonHack
            // 
            this.buttonHack.Enabled = false;
            this.buttonHack.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHack.Location = new System.Drawing.Point(341, 356);
            this.buttonHack.Name = "buttonHack";
            this.buttonHack.Size = new System.Drawing.Size(145, 37);
            this.buttonHack.TabIndex = 2;
            this.buttonHack.Text = "Взломать";
            this.buttonHack.UseVisualStyleBackColor = true;
            this.buttonHack.Click += new System.EventHandler(this.hackClick);
            // 
            // outputHack
            // 
            this.outputHack.Location = new System.Drawing.Point(8, 209);
            this.outputHack.Multiline = true;
            this.outputHack.Name = "outputHack";
            this.outputHack.ReadOnly = true;
            this.outputHack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputHack.Size = new System.Drawing.Size(629, 131);
            this.outputHack.TabIndex = 1;
            this.outputHack.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 28;
            this.label7.Text = "Результат:";
            // 
            // inputHack
            // 
            this.inputHack.Location = new System.Drawing.Point(8, 38);
            this.inputHack.Multiline = true;
            this.inputHack.Name = "inputHack";
            this.inputHack.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputHack.Size = new System.Drawing.Size(629, 129);
            this.inputHack.TabIndex = 0;
            this.inputHack.TextChanged += new System.EventHandler(this.hackChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(420, 26);
            this.label9.TabIndex = 26;
            this.label9.Text = "Введите зашифрованный текст в поле ниже:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.языкАлфавитаToolStripMenuItem,
            this.поУмолчаниюToolStripMenuItem});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "Опции";
            // 
            // языкАлфавитаToolStripMenuItem
            // 
            this.языкАлфавитаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.русскийToolStripMenuItem,
            this.английскийToolStripMenuItem,
            this.свойToolStripMenuItem});
            this.языкАлфавитаToolStripMenuItem.Name = "языкАлфавитаToolStripMenuItem";
            this.языкАлфавитаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.языкАлфавитаToolStripMenuItem.Text = "Язык алфавита";
            // 
            // русскийToolStripMenuItem
            // 
            this.русскийToolStripMenuItem.Name = "русскийToolStripMenuItem";
            this.русскийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.русскийToolStripMenuItem.Text = "Русский";
            this.русскийToolStripMenuItem.Click += new System.EventHandler(this.русскийToolStripMenuItem_Click);
            // 
            // английскийToolStripMenuItem
            // 
            this.английскийToolStripMenuItem.Checked = true;
            this.английскийToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.английскийToolStripMenuItem.Name = "английскийToolStripMenuItem";
            this.английскийToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.английскийToolStripMenuItem.Text = "Английский";
            this.английскийToolStripMenuItem.Click += new System.EventHandler(this.английскийToolStripMenuItem_Click);
            // 
            // свойToolStripMenuItem
            // 
            this.свойToolStripMenuItem.Name = "свойToolStripMenuItem";
            this.свойToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.свойToolStripMenuItem.Text = "Свой";
            this.свойToolStripMenuItem.Click += new System.EventHandler(this.свойToolStripMenuItem_Click);
            // 
            // поУмолчаниюToolStripMenuItem
            // 
            this.поУмолчаниюToolStripMenuItem.Name = "поУмолчаниюToolStripMenuItem";
            this.поУмолчаниюToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поУмолчаниюToolStripMenuItem.Text = "По умолчанию";
            this.поУмолчаниюToolStripMenuItem.Click += new System.EventHandler(this.поУмолчаниюToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ceasarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 469);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "ceasarForm";
            this.Text = "Шифр Цезаря";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void buttonHack_Click(object sender, EventArgs e) {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonCloseCr;
        private System.Windows.Forms.Button buttonCr;
        private System.Windows.Forms.TextBox outputResCr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputKeyCr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputCr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonCloseUCr;
        private System.Windows.Forms.Button buttonUCr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputKeyUCr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCloseHack;
        private System.Windows.Forms.Button buttonHack;
        private System.Windows.Forms.TextBox outputHack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox inputHack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem языкАлфавитаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem английскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem русскийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.TextBox outputResUCr;
        private System.Windows.Forms.TextBox inputUCr;
        private System.Windows.Forms.ToolStripMenuItem поУмолчаниюToolStripMenuItem;
    }
}

