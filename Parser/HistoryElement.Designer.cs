namespace Parser
{
    partial class HistoryElement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Count = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.request = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Count);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.request);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 41);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel1_MouseHover);
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count.ForeColor = System.Drawing.Color.White;
            this.Count.Location = new System.Drawing.Point(603, 10);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(19, 21);
            this.Count.TabIndex = 6;
            this.Count.Text = "0";
            this.Count.Click += new System.EventHandler(this.panel1_Click);
            this.Count.MouseEnter += new System.EventHandler(this.panel1_MouseHover);
            this.Count.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(568, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "-";
            this.label1.Click += new System.EventHandler(this.panel1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.panel1_MouseHover);
            this.label1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // request
            // 
            this.request.AutoSize = true;
            this.request.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.request.ForeColor = System.Drawing.Color.White;
            this.request.Location = new System.Drawing.Point(12, 10);
            this.request.Name = "request";
            this.request.Size = new System.Drawing.Size(0, 21);
            this.request.TabIndex = 4;
            this.request.Click += new System.EventHandler(this.panel1_Click);
            this.request.MouseEnter += new System.EventHandler(this.panel1_MouseHover);
            this.request.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            // 
            // HistoryElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.panel1);
            this.Name = "HistoryElement";
            this.Size = new System.Drawing.Size(657, 41);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label request;
    }
}
