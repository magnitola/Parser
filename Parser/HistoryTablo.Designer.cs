namespace Parser
{
    partial class HistoryTablo
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
            this.Datepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Datepicker
            // 
            this.Datepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.Datepicker.BorderRadius = 0;
            this.Datepicker.ForeColor = System.Drawing.Color.White;
            this.Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker.FormatCustom = null;
            this.Datepicker.Location = new System.Drawing.Point(20, 15);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.Size = new System.Drawing.Size(303, 36);
            this.Datepicker.TabIndex = 0;
            this.Datepicker.Value = new System.DateTime(2019, 12, 27, 9, 14, 55, 974);
            this.Datepicker.onValueChanged += new System.EventHandler(this.bunifuDatepicker1_onValueChanged);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Message.ForeColor = System.Drawing.Color.White;
            this.Message.Location = new System.Drawing.Point(365, 23);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(245, 21);
            this.Message.TabIndex = 2;
            this.Message.Text = "В этот день не было запросов";
            this.Message.Visible = false;
            // 
            // HistoryTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Datepicker);
            this.Name = "HistoryTablo";
            this.Size = new System.Drawing.Size(680, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDatepicker Datepicker;
        private System.Windows.Forms.Label Message;
    }
}
