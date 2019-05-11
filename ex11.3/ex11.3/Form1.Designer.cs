namespace ex11._3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.offsetMinus = new System.Windows.Forms.Button();
            this.offsetPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // offsetMinus
            // 
            this.offsetMinus.Location = new System.Drawing.Point(12, 373);
            this.offsetMinus.Name = "offsetMinus";
            this.offsetMinus.Size = new System.Drawing.Size(24, 23);
            this.offsetMinus.TabIndex = 3;
            this.offsetMinus.Text = "▼";
            this.offsetMinus.UseVisualStyleBackColor = true;
            this.offsetMinus.Click += new System.EventHandler(this.offsetMinus_Click);
            // 
            // offsetPlus
            // 
            this.offsetPlus.Location = new System.Drawing.Point(12, 353);
            this.offsetPlus.Name = "offsetPlus";
            this.offsetPlus.Size = new System.Drawing.Size(24, 23);
            this.offsetPlus.TabIndex = 2;
            this.offsetPlus.Text = "△";
            this.offsetPlus.UseVisualStyleBackColor = true;
            this.offsetPlus.Click += new System.EventHandler(this.offsetPlus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 416);
            this.Controls.Add(this.offsetMinus);
            this.Controls.Add(this.offsetPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button offsetMinus;
        private System.Windows.Forms.Button offsetPlus;
    }
}

