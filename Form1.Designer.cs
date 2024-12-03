namespace School
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_classes = new System.Windows.Forms.Button();
            this.button_teachers = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Ivory;
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(233, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 20, 120, 20);
            this.label1.Size = new System.Drawing.Size(280, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Школа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button_classes
            // 
            this.button_classes.BackColor = System.Drawing.Color.Ivory;
            this.button_classes.ForeColor = System.Drawing.Color.OliveDrab;
            this.button_classes.Location = new System.Drawing.Point(83, 50);
            this.button_classes.Margin = new System.Windows.Forms.Padding(3, 50, 3, 20);
            this.button_classes.Name = "button_classes";
            this.button_classes.Size = new System.Drawing.Size(271, 45);
            this.button_classes.TabIndex = 1;
            this.button_classes.Text = "Классы";
            this.button_classes.UseVisualStyleBackColor = false;
            this.button_classes.Click += new System.EventHandler(this.button_classes_Click);
            // 
            // button_teachers
            // 
            this.button_teachers.BackColor = System.Drawing.Color.Ivory;
            this.button_teachers.ForeColor = System.Drawing.Color.OliveDrab;
            this.button_teachers.Location = new System.Drawing.Point(83, 118);
            this.button_teachers.Name = "button_teachers";
            this.button_teachers.Size = new System.Drawing.Size(271, 45);
            this.button_teachers.TabIndex = 2;
            this.button_teachers.Text = "Учителя";
            this.button_teachers.UseVisualStyleBackColor = false;
            this.button_teachers.Click += new System.EventHandler(this.button_teachers_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightYellow;
            this.flowLayoutPanel1.Controls.Add(this.button_classes);
            this.flowLayoutPanel1.Controls.Add(this.button_teachers);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(153, 132);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(80, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(436, 200);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(765, 391);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Violet;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_classes;
        private System.Windows.Forms.Button button_teachers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

