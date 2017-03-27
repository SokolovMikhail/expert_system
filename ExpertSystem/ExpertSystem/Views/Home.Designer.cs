namespace ExpertSystem
{
    partial class Home
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.startbutton = new System.Windows.Forms.Button();
            this.topicsComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(176, 74);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(246, 111);
            this.startbutton.TabIndex = 0;
            this.startbutton.Text = "Перейти к тестированию";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // topicsComboBox
            // 
            this.topicsComboBox.FormattingEnabled = true;
            this.topicsComboBox.Location = new System.Drawing.Point(113, 47);
            this.topicsComboBox.Name = "topicsComboBox";
            this.topicsComboBox.Size = new System.Drawing.Size(387, 21);
            this.topicsComboBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "Настройки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 320);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.topicsComboBox);
            this.Controls.Add(this.startbutton);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.ComboBox topicsComboBox;
        private System.Windows.Forms.Button button1;
    }
}

