using System.Drawing;

namespace Задача_2_Вариант_14
{
    partial class UltraSonick
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu1 = new Задача_2_Вариант_14.UltraBlock.Menu();
            this.измеренияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сравненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.измеренияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu1
            // 
            
            // 
            // измеренияToolStripMenuItem
            // 
            this.измеренияToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.измеренияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сравненияToolStripMenuItem,
            this.измеренияToolStripMenuItem1});
            this.измеренияToolStripMenuItem.Name = "измеренияToolStripMenuItem";
            this.измеренияToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.измеренияToolStripMenuItem.Text = " ";
            // 
            // сравненияToolStripMenuItem
            // 
            this.сравненияToolStripMenuItem.Name = "сравненияToolStripMenuItem";
            this.сравненияToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.сравненияToolStripMenuItem.Text = "Сравнения";
            // 
            // измеренияToolStripMenuItem1
            // 
            this.измеренияToolStripMenuItem1.Name = "измеренияToolStripMenuItem1";
            this.измеренияToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.измеренияToolStripMenuItem1.Text = "Измерения";
            // 
            // UltraSonick
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.menu1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(77, 77);
            this.Name = "UltraSonick";
            this.Size = new System.Drawing.Size(211, 223);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UltraSonick_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UltraSonick_MouseMove);
            this.menu1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menu1.BackColor = System.Drawing.Color.Black;
            this.menu1.Dock = System.Windows.Forms.DockStyle.None;
            this.menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.измеренияToolStripMenuItem});
            this.menu1.Location = new System.Drawing.Point(Width/2,Height/2);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(150, 24);
            this.menu1.TabIndex = 0;
            this.menu1.Text = "menu1";
            this.menu1.ResumeLayout(false);
            this.menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UltraBlock.Menu menu1;
        private System.Windows.Forms.ToolStripMenuItem измеренияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сравненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem измеренияToolStripMenuItem1;
    }
}
