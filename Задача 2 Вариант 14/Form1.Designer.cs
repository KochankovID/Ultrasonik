namespace Задача_2_Вариант_14
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
            this.ultraSonick1 = new Задача_2_Вариант_14.UltraSonick();
            this.ultraSonick2 = new Задача_2_Вариант_14.UltraSonick();
            this.ultraSonick3 = new Задача_2_Вариант_14.UltraSonick();
            this.ultraSonick4 = new Задача_2_Вариант_14.UltraSonick();
            this.SuspendLayout();
            // 
            // ultraSonick1
            // 
            this.ultraSonick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ultraSonick1.Location = new System.Drawing.Point(223, 138);
            this.ultraSonick1.MinimumSize = new System.Drawing.Size(80, 135);
            this.ultraSonick1.Name = "ultraSonick1";
            this.ultraSonick1.Size = new System.Drawing.Size(267, 331);
            this.ultraSonick1.TabIndex = 0;
            // 
            // ultraSonick2
            // 
            this.ultraSonick2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ultraSonick2.Location = new System.Drawing.Point(6, 192);
            this.ultraSonick2.MinimumSize = new System.Drawing.Size(80, 135);
            this.ultraSonick2.Name = "ultraSonick2";
            this.ultraSonick2.Size = new System.Drawing.Size(211, 223);
            this.ultraSonick2.TabIndex = 1;
            // 
            // ultraSonick3
            // 
            this.ultraSonick3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ultraSonick3.Location = new System.Drawing.Point(6, 2);
            this.ultraSonick3.MinimumSize = new System.Drawing.Size(80, 135);
            this.ultraSonick3.Name = "ultraSonick3";
            this.ultraSonick3.Size = new System.Drawing.Size(211, 223);
            this.ultraSonick3.TabIndex = 2;
            // 
            // ultraSonick4
            // 
            this.ultraSonick4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ultraSonick4.Location = new System.Drawing.Point(248, -19);
            this.ultraSonick4.MinimumSize = new System.Drawing.Size(80, 135);
            this.ultraSonick4.Name = "ultraSonick4";
            this.ultraSonick4.Size = new System.Drawing.Size(211, 223);
            this.ultraSonick4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.ultraSonick4);
            this.Controls.Add(this.ultraSonick3);
            this.Controls.Add(this.ultraSonick2);
            this.Controls.Add(this.ultraSonick1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UltraSonick ultraSonick1;
        private UltraSonick ultraSonick2;
        private UltraSonick ultraSonick3;
        private UltraSonick ultraSonick4;
    }
}

