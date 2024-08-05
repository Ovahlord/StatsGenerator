namespace statsGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            button1 = new Button();
            strOffset = new TextBox();
            agiOffset = new TextBox();
            staOffset = new TextBox();
            intOffset = new TextBox();
            spiOffset = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            humanRacialCheckBox = new CheckBox();
            classDropdown = new ComboBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            startLevel = new TextBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(39, 33);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(479, 697);
            inputTextBox.TabIndex = 0;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(524, 33);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(479, 697);
            outputTextBox.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1121, 733);
            button1.Name = "button1";
            button1.Size = new Size(178, 51);
            button1.TabIndex = 2;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += button1_MouseClick;
            // 
            // strOffset
            // 
            strOffset.Location = new Point(42, 80);
            strOffset.Margin = new Padding(6, 3, 6, 3);
            strOffset.Name = "strOffset";
            strOffset.Size = new Size(26, 23);
            strOffset.TabIndex = 3;
            strOffset.Text = "0";
            // 
            // agiOffset
            // 
            agiOffset.Location = new Point(78, 80);
            agiOffset.Margin = new Padding(6, 3, 6, 3);
            agiOffset.Name = "agiOffset";
            agiOffset.Size = new Size(26, 23);
            agiOffset.TabIndex = 4;
            agiOffset.Text = "0";
            // 
            // staOffset
            // 
            staOffset.Location = new Point(116, 80);
            staOffset.Margin = new Padding(6, 3, 6, 3);
            staOffset.Name = "staOffset";
            staOffset.Size = new Size(26, 23);
            staOffset.TabIndex = 5;
            staOffset.Text = "0";
            // 
            // intOffset
            // 
            intOffset.Location = new Point(154, 80);
            intOffset.Margin = new Padding(6, 3, 6, 3);
            intOffset.Name = "intOffset";
            intOffset.Size = new Size(26, 23);
            intOffset.TabIndex = 6;
            intOffset.Text = "0";
            // 
            // spiOffset
            // 
            spiOffset.Location = new Point(192, 80);
            spiOffset.Margin = new Padding(6, 3, 6, 3);
            spiOffset.Name = "spiOffset";
            spiOffset.Size = new Size(26, 23);
            spiOffset.TabIndex = 7;
            spiOffset.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 34);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 8;
            label1.Text = "Race Stats Offsets";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 62);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 9;
            label2.Text = "Str";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 62);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 10;
            label3.Text = "Agi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 62);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 11;
            label4.Text = "Sta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(154, 62);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 12;
            label5.Text = "Int";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 62);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 13;
            label6.Text = "Spi";
            // 
            // humanRacialCheckBox
            // 
            humanRacialCheckBox.AutoSize = true;
            humanRacialCheckBox.Checked = true;
            humanRacialCheckBox.CheckState = CheckState.Checked;
            humanRacialCheckBox.Location = new Point(42, 109);
            humanRacialCheckBox.Name = "humanRacialCheckBox";
            humanRacialCheckBox.Size = new Size(203, 19);
            humanRacialCheckBox.TabIndex = 14;
            humanRacialCheckBox.Text = "Subtract Human Racial (3% spirit)";
            humanRacialCheckBox.UseVisualStyleBackColor = true;
            // 
            // classDropdown
            // 
            classDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            classDropdown.FormattingEnabled = true;
            classDropdown.Items.AddRange(new object[] { "CLASS_WARRIOR", "CLASS_PALADIN", "CLASS_HUNTER", "CLASS_ROGUE", "CLASS_PRIEST", "CLASS_DEATH_KNIGHT", "CLASS_SHAMAN", "CLASS_MAGE", "CLASS_WARLOCK", "CLASS_DRUID" });
            classDropdown.Location = new Point(1027, 213);
            classDropdown.Name = "classDropdown";
            classDropdown.Size = new Size(203, 23);
            classDropdown.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1027, 195);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 16;
            label7.Text = "Class";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(strOffset);
            groupBox1.Controls.Add(humanRacialCheckBox);
            groupBox1.Controls.Add(agiOffset);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(staOffset);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(intOffset);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(spiOffset);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(1027, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(283, 142);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Stats Settings";
            // 
            // startLevel
            // 
            startLevel.Location = new Point(1027, 275);
            startLevel.Margin = new Padding(6, 3, 6, 3);
            startLevel.Name = "startLevel";
            startLevel.Size = new Size(51, 23);
            startLevel.TabIndex = 15;
            startLevel.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1027, 257);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 16;
            label8.Text = "Start Level";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 796);
            Controls.Add(startLevel);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(classDropdown);
            Controls.Add(button1);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Stats Generator";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button button1;
        private TextBox strOffset;
        private TextBox agiOffset;
        private TextBox staOffset;
        private TextBox intOffset;
        private TextBox spiOffset;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox humanRacialCheckBox;
        private ComboBox classDropdown;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox startLevel;
        private Label label8;
    }
}
