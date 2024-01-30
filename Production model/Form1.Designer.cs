namespace Production_model
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gameModeCheckBox = new System.Windows.Forms.CheckBox();
            this.RulesBox = new System.Windows.Forms.TextBox();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.ElementsLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FactsBox = new System.Windows.Forms.ListBox();
            this.reset = new System.Windows.Forms.Button();
            this.OwnElementsLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.PlusLabel = new System.Windows.Forms.Label();
            this.SecondElem = new System.Windows.Forms.ListBox();
            this.FirstElem = new System.Windows.Forms.ListBox();
            this.SecondElComboBox = new System.Windows.Forms.ComboBox();
            this.MagicLabel = new System.Windows.Forms.Label();
            this.PrintLabel = new System.Windows.Forms.Label();
            this.InElementsLabel = new System.Windows.Forms.Label();
            this.returnPrntCheckBox = new System.Windows.Forms.CheckBox();
            this.OutFactsBox = new System.Windows.Forms.ListBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.InFactsBox = new System.Windows.Forms.ListBox();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.MediumPurple;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.MediumPurple;
            this.splitContainer1.Panel1.Controls.Add(this.gameModeCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.RulesBox);
            this.splitContainer1.Panel1.Controls.Add(this.LogoPictureBox);
            this.splitContainer1.Panel1.Controls.Add(this.ElementsLabel);
            this.splitContainer1.Panel1.Controls.Add(this.NameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.FactsBox);
            this.splitContainer1.Panel1.Controls.Add(this.reset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.MediumPurple;
            this.splitContainer1.Panel2.Controls.Add(this.OwnElementsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.compareButton);
            this.splitContainer1.Panel2.Controls.Add(this.PlusLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SecondElem);
            this.splitContainer1.Panel2.Controls.Add(this.FirstElem);
            this.splitContainer1.Panel2.Controls.Add(this.SecondElComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.MagicLabel);
            this.splitContainer1.Panel2.Controls.Add(this.PrintLabel);
            this.splitContainer1.Panel2.Controls.Add(this.InElementsLabel);
            this.splitContainer1.Panel2.Controls.Add(this.returnPrntCheckBox);
            this.splitContainer1.Panel2.Controls.Add(this.OutFactsBox);
            this.splitContainer1.Panel2.Controls.Add(this.ResultBox);
            this.splitContainer1.Panel2.Controls.Add(this.InFactsBox);
            this.splitContainer1.Panel2.Controls.Add(this.start);
            this.splitContainer1.Size = new System.Drawing.Size(1560, 770);
            this.splitContainer1.SplitterDistance = 518;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // gameModeCheckBox
            // 
            this.gameModeCheckBox.AutoSize = true;
            this.gameModeCheckBox.Location = new System.Drawing.Point(400, 64);
            this.gameModeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gameModeCheckBox.Name = "gameModeCheckBox";
            this.gameModeCheckBox.Size = new System.Drawing.Size(101, 20);
            this.gameModeCheckBox.TabIndex = 9;
            this.gameModeCheckBox.Text = "GameMode";
            this.gameModeCheckBox.UseVisualStyleBackColor = true;
            this.gameModeCheckBox.CheckedChanged += new System.EventHandler(this.gameModeCheckBox_CheckedChanged);
            // 
            // RulesBox
            // 
            this.RulesBox.Location = new System.Drawing.Point(39, 91);
            this.RulesBox.Margin = new System.Windows.Forms.Padding(4);
            this.RulesBox.Multiline = true;
            this.RulesBox.Name = "RulesBox";
            this.RulesBox.ReadOnly = true;
            this.RulesBox.Size = new System.Drawing.Size(432, 148);
            this.RulesBox.TabIndex = 9;
            this.RulesBox.Text = "Ласкаво просимо до Double God Game!\r\n\r\nДопоможіть Богові створити світ, поєднуючи" +
    " елементи.\r\nДля цього виберіть два елементи, які хочете з\'єднати, та подивіться," +
    " що вийде!\r\n\r\nУспіхів!";
            this.RulesBox.Visible = false;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.BackgroundImage")));
            this.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPictureBox.Location = new System.Drawing.Point(4, 2);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(103, 85);
            this.LogoPictureBox.TabIndex = 8;
            this.LogoPictureBox.TabStop = false;
            // 
            // ElementsLabel
            // 
            this.ElementsLabel.AutoSize = true;
            this.ElementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ElementsLabel.Location = new System.Drawing.Point(173, 63);
            this.ElementsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ElementsLabel.Name = "ElementsLabel";
            this.ElementsLabel.Size = new System.Drawing.Size(110, 25);
            this.ElementsLabel.TabIndex = 3;
            this.ElementsLabel.Text = "Елементи";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameLabel.Location = new System.Drawing.Point(115, 15);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(300, 39);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Double God Game";
            // 
            // FactsBox
            // 
            this.FactsBox.FormattingEnabled = true;
            this.FactsBox.ItemHeight = 16;
            this.FactsBox.Location = new System.Drawing.Point(4, 91);
            this.FactsBox.Margin = new System.Windows.Forms.Padding(4);
            this.FactsBox.Name = "FactsBox";
            this.FactsBox.Size = new System.Drawing.Size(503, 676);
            this.FactsBox.TabIndex = 1;
            this.FactsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FactsBox_MouseDoubleClick);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(292, 59);
            this.reset.Margin = new System.Windows.Forms.Padding(4);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(100, 28);
            this.reset.TabIndex = 0;
            this.reset.Text = "Скинути";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // OwnElementsLabel
            // 
            this.OwnElementsLabel.AutoSize = true;
            this.OwnElementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OwnElementsLabel.Location = new System.Drawing.Point(549, 23);
            this.OwnElementsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OwnElementsLabel.Name = "OwnElementsLabel";
            this.OwnElementsLabel.Size = new System.Drawing.Size(360, 29);
            this.OwnElementsLabel.TabIndex = 14;
            this.OwnElementsLabel.Text = "Отримано елементів : 4 з 126";
            this.OwnElementsLabel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(553, 544);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(435, 222);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Спробуй щось об\'єднати!";
            this.textBox1.Visible = false;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(701, 496);
            this.compareButton.Margin = new System.Windows.Forms.Padding(4);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(128, 28);
            this.compareButton.TabIndex = 12;
            this.compareButton.Text = "Об\'єднати";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Visible = false;
            this.compareButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.compareButton_MouseClick);
            // 
            // PlusLabel
            // 
            this.PlusLabel.AutoSize = true;
            this.PlusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusLabel.Location = new System.Drawing.Point(739, 263);
            this.PlusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlusLabel.Name = "PlusLabel";
            this.PlusLabel.Size = new System.Drawing.Size(37, 39);
            this.PlusLabel.TabIndex = 11;
            this.PlusLabel.Text = "+";
            this.PlusLabel.Visible = false;
            // 
            // SecondElem
            // 
            this.SecondElem.FormattingEnabled = true;
            this.SecondElem.ItemHeight = 16;
            this.SecondElem.Location = new System.Drawing.Point(553, 305);
            this.SecondElem.Margin = new System.Windows.Forms.Padding(4);
            this.SecondElem.Name = "SecondElem";
            this.SecondElem.Size = new System.Drawing.Size(435, 164);
            this.SecondElem.TabIndex = 10;
            this.SecondElem.Visible = false;
            this.SecondElem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SecondElem_MouseDoubleClick);
            // 
            // FirstElem
            // 
            this.FirstElem.FormattingEnabled = true;
            this.FirstElem.ItemHeight = 16;
            this.FirstElem.Location = new System.Drawing.Point(553, 94);
            this.FirstElem.Margin = new System.Windows.Forms.Padding(4);
            this.FirstElem.Name = "FirstElem";
            this.FirstElem.Size = new System.Drawing.Size(435, 164);
            this.FirstElem.TabIndex = 9;
            this.FirstElem.Visible = false;
            this.FirstElem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FirstElem_MouseDoubleClick);
            // 
            // SecondElComboBox
            // 
            this.SecondElComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondElComboBox.FormattingEnabled = true;
            this.SecondElComboBox.Location = new System.Drawing.Point(284, 92);
            this.SecondElComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SecondElComboBox.Name = "SecondElComboBox";
            this.SecondElComboBox.Size = new System.Drawing.Size(259, 24);
            this.SecondElComboBox.TabIndex = 8;
            this.SecondElComboBox.Visible = false;
            // 
            // MagicLabel
            // 
            this.MagicLabel.AutoSize = true;
            this.MagicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MagicLabel.Location = new System.Drawing.Point(279, 64);
            this.MagicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MagicLabel.Name = "MagicLabel";
            this.MagicLabel.Size = new System.Drawing.Size(272, 25);
            this.MagicLabel.TabIndex = 7;
            this.MagicLabel.Text = "Вжух, отримали елементи!";
            // 
            // PrintLabel
            // 
            this.PrintLabel.AutoSize = true;
            this.PrintLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PrintLabel.Location = new System.Drawing.Point(631, 64);
            this.PrintLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PrintLabel.Name = "PrintLabel";
            this.PrintLabel.Size = new System.Drawing.Size(139, 25);
            this.PrintLabel.TabIndex = 6;
            this.PrintLabel.Text = "Прямий вивід";
            // 
            // InElementsLabel
            // 
            this.InElementsLabel.AutoSize = true;
            this.InElementsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InElementsLabel.Location = new System.Drawing.Point(-1, 63);
            this.InElementsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InElementsLabel.Name = "InElementsLabel";
            this.InElementsLabel.Size = new System.Drawing.Size(183, 25);
            this.InElementsLabel.TabIndex = 5;
            this.InElementsLabel.Text = "Вибрані елементи";
            // 
            // returnPrntCheckBox
            // 
            this.returnPrntCheckBox.AutoSize = true;
            this.returnPrntCheckBox.Location = new System.Drawing.Point(131, 22);
            this.returnPrntCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.returnPrntCheckBox.Name = "returnPrntCheckBox";
            this.returnPrntCheckBox.Size = new System.Drawing.Size(94, 20);
            this.returnPrntCheckBox.TabIndex = 4;
            this.returnPrntCheckBox.Text = "ReturnPrint";
            this.returnPrntCheckBox.UseVisualStyleBackColor = true;
            this.returnPrntCheckBox.CheckedChanged += new System.EventHandler(this.returnPrntCheckBox_CheckedChanged);
            // 
            // OutFactsBox
            // 
            this.OutFactsBox.FormattingEnabled = true;
            this.OutFactsBox.ItemHeight = 16;
            this.OutFactsBox.Location = new System.Drawing.Point(284, 92);
            this.OutFactsBox.Margin = new System.Windows.Forms.Padding(4);
            this.OutFactsBox.Name = "OutFactsBox";
            this.OutFactsBox.Size = new System.Drawing.Size(259, 676);
            this.OutFactsBox.TabIndex = 3;
            this.OutFactsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OutFactsBox_MouseDoubleClick);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(552, 92);
            this.ResultBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultBox.Size = new System.Drawing.Size(451, 675);
            this.ResultBox.TabIndex = 2;
            // 
            // InFactsBox
            // 
            this.InFactsBox.FormattingEnabled = true;
            this.InFactsBox.ItemHeight = 16;
            this.InFactsBox.Location = new System.Drawing.Point(4, 92);
            this.InFactsBox.Margin = new System.Windows.Forms.Padding(4);
            this.InFactsBox.Name = "InFactsBox";
            this.InFactsBox.Size = new System.Drawing.Size(271, 676);
            this.InFactsBox.TabIndex = 1;
            this.InFactsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.InFactsBox_MouseDoubleClick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(23, 15);
            this.start.Margin = new System.Windows.Forms.Padding(4);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 28);
            this.start.TabIndex = 0;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.startButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1560, 770);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Double God Game";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox FactsBox;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.ListBox InFactsBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ListBox OutFactsBox;
        private System.Windows.Forms.CheckBox returnPrntCheckBox;
        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Label ElementsLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label MagicLabel;
        private System.Windows.Forms.Label PrintLabel;
        private System.Windows.Forms.Label InElementsLabel;
        private System.Windows.Forms.ComboBox SecondElComboBox;
        private System.Windows.Forms.TextBox RulesBox;
        private System.Windows.Forms.CheckBox gameModeCheckBox;
        private System.Windows.Forms.Label PlusLabel;
        private System.Windows.Forms.ListBox SecondElem;
        private System.Windows.Forms.ListBox FirstElem;
        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label OwnElementsLabel;
    }
}

