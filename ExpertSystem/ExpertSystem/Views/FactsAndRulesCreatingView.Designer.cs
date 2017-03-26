namespace ExpertSystem
{
    partial class FactsAndRulesCreatingView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addFactButton = new System.Windows.Forms.Button();
            this.valueText = new System.Windows.Forms.TextBox();
            this.attributeText = new System.Windows.Forms.TextBox();
            this.objectText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.condtionText = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rulesList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.factsList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(634, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addFactButton);
            this.tabPage1.Controls.Add(this.valueText);
            this.tabPage1.Controls.Add(this.attributeText);
            this.tabPage1.Controls.Add(this.objectText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Факты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addFactButton
            // 
            this.addFactButton.Location = new System.Drawing.Point(303, 67);
            this.addFactButton.Name = "addFactButton";
            this.addFactButton.Size = new System.Drawing.Size(142, 23);
            this.addFactButton.TabIndex = 4;
            this.addFactButton.Text = "Добавить факт ->";
            this.addFactButton.UseVisualStyleBackColor = true;
            this.addFactButton.Click += new System.EventHandler(this.addFactButton_Click);
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(303, 41);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(317, 20);
            this.valueText.TabIndex = 2;
            // 
            // attributeText
            // 
            this.attributeText.Location = new System.Drawing.Point(155, 41);
            this.attributeText.Name = "attributeText";
            this.attributeText.Size = new System.Drawing.Size(142, 20);
            this.attributeText.TabIndex = 1;
            // 
            // objectText
            // 
            this.objectText.Location = new System.Drawing.Point(7, 41);
            this.objectText.Name = "objectText";
            this.objectText.Size = new System.Drawing.Size(142, 20);
            this.objectText.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.resultText);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.condtionText);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.rulesList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Правила";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить правило";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // condtionText
            // 
            this.condtionText.Location = new System.Drawing.Point(6, 43);
            this.condtionText.Name = "condtionText";
            this.condtionText.Size = new System.Drawing.Size(322, 56);
            this.condtionText.TabIndex = 4;
            this.condtionText.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Список правил";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rulesList
            // 
            this.rulesList.FormattingEnabled = true;
            this.rulesList.Location = new System.Drawing.Point(347, 23);
            this.rulesList.Name = "rulesList";
            this.rulesList.Size = new System.Drawing.Size(256, 342);
            this.rulesList.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.richTextBox3);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(626, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вопросы";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Добавить вопрос";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Машинопонятная формулировка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Человекопонятная формулировка";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(337, 30);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(202, 293);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(3, 30);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(317, 293);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // factsList
            // 
            this.factsList.Location = new System.Drawing.Point(653, 58);
            this.factsList.Name = "factsList";
            this.factsList.Size = new System.Drawing.Size(503, 363);
            this.factsList.TabIndex = 3;
            this.factsList.UseCompatibleStateImageBehavior = false;
            this.factsList.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список существующих фактов";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(6, 105);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(322, 56);
            this.resultText.TabIndex = 6;
            this.resultText.Text = "";
            // 
            // FactsAndRulesCreatingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.factsList);
            this.Name = "FactsAndRulesCreatingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FactsAndRulesCreatingView";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addFactButton;
        private System.Windows.Forms.ListView factsList;
        private System.Windows.Forms.TextBox valueText;
        private System.Windows.Forms.TextBox attributeText;
        private System.Windows.Forms.TextBox objectText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox rulesList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox condtionText;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox resultText;
    }
}