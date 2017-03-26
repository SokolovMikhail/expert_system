namespace ExpertSystem.Views
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.objectText = new System.Windows.Forms.TextBox();
            this.attributeText = new System.Windows.Forms.TextBox();
            this.valueText = new System.Windows.Forms.TextBox();
            this.factsList = new System.Windows.Forms.ListView();
            this.addFactButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.factsList2 = new System.Windows.Forms.ListBox();
            this.rulesList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(853, 412);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addFactButton);
            this.tabPage1.Controls.Add(this.factsList);
            this.tabPage1.Controls.Add(this.valueText);
            this.tabPage1.Controls.Add(this.attributeText);
            this.tabPage1.Controls.Add(this.objectText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(845, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Факты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.rulesList);
            this.tabPage2.Controls.Add(this.factsList2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(845, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Правила";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(845, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вопросы";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // objectText
            // 
            this.objectText.Location = new System.Drawing.Point(7, 41);
            this.objectText.Name = "objectText";
            this.objectText.Size = new System.Drawing.Size(142, 20);
            this.objectText.TabIndex = 0;
            // 
            // attributeText
            // 
            this.attributeText.Location = new System.Drawing.Point(155, 41);
            this.attributeText.Name = "attributeText";
            this.attributeText.Size = new System.Drawing.Size(142, 20);
            this.attributeText.TabIndex = 1;
            // 
            // valueText
            // 
            this.valueText.Location = new System.Drawing.Point(303, 41);
            this.valueText.Name = "valueText";
            this.valueText.Size = new System.Drawing.Size(278, 20);
            this.valueText.TabIndex = 2;
            // 
            // factsList
            // 
            this.factsList.Location = new System.Drawing.Point(587, 41);
            this.factsList.Name = "factsList";
            this.factsList.Size = new System.Drawing.Size(252, 330);
            this.factsList.TabIndex = 3;
            this.factsList.UseCompatibleStateImageBehavior = false;
            // 
            // addFactButton
            // 
            this.addFactButton.Location = new System.Drawing.Point(303, 67);
            this.addFactButton.Name = "addFactButton";
            this.addFactButton.Size = new System.Drawing.Size(142, 23);
            this.addFactButton.TabIndex = 4;
            this.addFactButton.Text = "Добавить факт ->";
            this.addFactButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список существующих фактов";
            // 
            // factsList2
            // 
            this.factsList2.FormattingEnabled = true;
            this.factsList2.Location = new System.Drawing.Point(335, 23);
            this.factsList2.Name = "factsList2";
            this.factsList2.Size = new System.Drawing.Size(242, 342);
            this.factsList2.TabIndex = 0;
            // 
            // rulesList
            // 
            this.rulesList.FormattingEnabled = true;
            this.rulesList.Location = new System.Drawing.Point(583, 23);
            this.rulesList.Name = "rulesList";
            this.rulesList.Size = new System.Drawing.Size(256, 342);
            this.rulesList.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Список фактов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Список правил";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(322, 163);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить правило";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FactsAndRulesCreatingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 438);
            this.Controls.Add(this.tabControl1);
            this.Name = "FactsAndRulesCreatingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FactsAndRulesCreatingView";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox rulesList;
        private System.Windows.Forms.ListBox factsList2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}