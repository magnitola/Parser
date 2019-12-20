namespace Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NumberPage = new System.Windows.Forms.Label();
            this.Article5 = new Parser.ViewArticle();
            this.Article4 = new Parser.ViewArticle();
            this.Article3 = new Parser.ViewArticle();
            this.Article2 = new Parser.ViewArticle();
            this.Article1 = new Parser.ViewArticle();
            this.search = new Parser.SearchBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(75)))), ((int)(((byte)(105)))));
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 50);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 536);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.panel3.Controls.Add(this.NumberPage);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.Article5);
            this.panel3.Controls.Add(this.Article4);
            this.panel3.Controls.Add(this.Article3);
            this.panel3.Controls.Add(this.Article2);
            this.panel3.Controls.Add(this.Article1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(184, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 536);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 504);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Вперед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NumberPage
            // 
            this.NumberPage.AutoSize = true;
            this.NumberPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPage.ForeColor = System.Drawing.Color.White;
            this.NumberPage.Location = new System.Drawing.Point(322, 508);
            this.NumberPage.Name = "NumberPage";
            this.NumberPage.Size = new System.Drawing.Size(0, 17);
            this.NumberPage.TabIndex = 7;
            // 
            // Article5
            // 
            this.Article5.ArticleDate = "";
            this.Article5.ArticleText = "";
            this.Article5.ArticleTitle = "";
            this.Article5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article5.Location = new System.Drawing.Point(6, 402);
            this.Article5.Name = "Article5";
            this.Article5.Size = new System.Drawing.Size(655, 93);
            this.Article5.TabIndex = 4;
            // 
            // Article4
            // 
            this.Article4.ArticleDate = "";
            this.Article4.ArticleText = "";
            this.Article4.ArticleTitle = "";
            this.Article4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article4.Location = new System.Drawing.Point(6, 303);
            this.Article4.Name = "Article4";
            this.Article4.Size = new System.Drawing.Size(655, 93);
            this.Article4.TabIndex = 3;
            // 
            // Article3
            // 
            this.Article3.ArticleDate = "";
            this.Article3.ArticleText = "";
            this.Article3.ArticleTitle = "";
            this.Article3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article3.Location = new System.Drawing.Point(6, 204);
            this.Article3.Name = "Article3";
            this.Article3.Size = new System.Drawing.Size(655, 93);
            this.Article3.TabIndex = 2;
            // 
            // Article2
            // 
            this.Article2.ArticleDate = "";
            this.Article2.ArticleText = "";
            this.Article2.ArticleTitle = "";
            this.Article2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article2.Location = new System.Drawing.Point(6, 105);
            this.Article2.Name = "Article2";
            this.Article2.Size = new System.Drawing.Size(655, 93);
            this.Article2.TabIndex = 1;
            // 
            // Article1
            // 
            this.Article1.ArticleDate = "";
            this.Article1.ArticleText = "";
            this.Article1.ArticleTitle = "";
            this.Article1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article1.Location = new System.Drawing.Point(6, 6);
            this.Article1.Name = "Article1";
            this.Article1.Size = new System.Drawing.Size(655, 93);
            this.Article1.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.search.Color = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.search.CustomText = "What are you looking for?";
            this.search.Location = new System.Drawing.Point(248, 8);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(329, 34);
            this.search.TabIndex = 2;
            this.search.Enter += new System.EventHandler(this.bunifuTextbox1_Enter);
            this.search.Leave += new System.EventHandler(this.search_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 586);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SearchBar search;
        private ViewArticle Article5;
        private ViewArticle Article4;
        private ViewArticle Article3;
        private ViewArticle Article2;
        private ViewArticle Article1;
        private System.Windows.Forms.Label NumberPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

