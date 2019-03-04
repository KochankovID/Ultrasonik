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
            this.SuspendLayout();
            // 
            // ultraSonick1
            // 
            this.ultraSonick1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ultraSonick1.Location = new System.Drawing.Point(54, 99);
            this.ultraSonick1.Name = "ultraSonick1";
            this.ultraSonick1.Size = new System.Drawing.Size(379, 286);
            this.ultraSonick1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.ultraSonick1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UltraSonick ultraSonick1;
    }
}

