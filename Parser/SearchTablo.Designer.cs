namespace Parser
{
    partial class SearchTablo
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
            this.Article1 = new Parser.ViewArticle();
            this.Article2 = new Parser.ViewArticle();
            this.CountArticle = new System.Windows.Forms.Label();
            this.Article3 = new Parser.ViewArticle();
            this.label1 = new System.Windows.Forms.Label();
            this.Article4 = new Parser.ViewArticle();
            this.NumberPage = new System.Windows.Forms.Label();
            this.Article5 = new Parser.ViewArticle();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Article1
            // 
            this.Article1.ArticleDate = "";
            this.Article1.ArticleText = "";
            this.Article1.ArticleTitle = "";
            this.Article1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article1.Location = new System.Drawing.Point(13, 6);
            this.Article1.Name = "Article1";
            this.Article1.Size = new System.Drawing.Size(655, 93);
            this.Article1.TabIndex = 10;
            // 
            // Article2
            // 
            this.Article2.ArticleDate = "";
            this.Article2.ArticleText = "";
            this.Article2.ArticleTitle = "";
            this.Article2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article2.Location = new System.Drawing.Point(13, 105);
            this.Article2.Name = "Article2";
            this.Article2.Size = new System.Drawing.Size(655, 93);
            this.Article2.TabIndex = 12;
            // 
            // CountArticle
            // 
            this.CountArticle.AutoSize = true;
            this.CountArticle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountArticle.ForeColor = System.Drawing.Color.White;
            this.CountArticle.Location = new System.Drawing.Point(612, 507);
            this.CountArticle.Name = "CountArticle";
            this.CountArticle.Size = new System.Drawing.Size(15, 17);
            this.CountArticle.TabIndex = 19;
            this.CountArticle.Text = "0";
            // 
            // Article3
            // 
            this.Article3.ArticleDate = "";
            this.Article3.ArticleText = "";
            this.Article3.ArticleTitle = "";
            this.Article3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article3.Location = new System.Drawing.Point(13, 204);
            this.Article3.Name = "Article3";
            this.Article3.Size = new System.Drawing.Size(655, 93);
            this.Article3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(512, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Всего статей: ";
            // 
            // Article4
            // 
            this.Article4.ArticleDate = "";
            this.Article4.ArticleText = "";
            this.Article4.ArticleTitle = "";
            this.Article4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article4.Location = new System.Drawing.Point(13, 303);
            this.Article4.Name = "Article4";
            this.Article4.Size = new System.Drawing.Size(655, 93);
            this.Article4.TabIndex = 15;
            // 
            // NumberPage
            // 
            this.NumberPage.AutoSize = true;
            this.NumberPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPage.ForeColor = System.Drawing.Color.White;
            this.NumberPage.Location = new System.Drawing.Point(329, 508);
            this.NumberPage.Name = "NumberPage";
            this.NumberPage.Size = new System.Drawing.Size(0, 17);
            this.NumberPage.TabIndex = 17;
            // 
            // Article5
            // 
            this.Article5.ArticleDate = "";
            this.Article5.ArticleText = "";
            this.Article5.ArticleTitle = "";
            this.Article5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article5.Location = new System.Drawing.Point(13, 402);
            this.Article5.Name = "Article5";
            this.Article5.Size = new System.Drawing.Size(655, 93);
            this.Article5.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Вперед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchTablo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.Article1);
            this.Controls.Add(this.Article2);
            this.Controls.Add(this.CountArticle);
            this.Controls.Add(this.Article3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Article4);
            this.Controls.Add(this.NumberPage);
            this.Controls.Add(this.Article5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SearchTablo";
            this.Size = new System.Drawing.Size(680, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ViewArticle Article1;
        private ViewArticle Article2;
        private System.Windows.Forms.Label CountArticle;
        private ViewArticle Article3;
        private System.Windows.Forms.Label label1;
        private ViewArticle Article4;
        private System.Windows.Forms.Label NumberPage;
        private ViewArticle Article5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
