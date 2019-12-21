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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.CountArticle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberPage = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.Article1 = new Parser.ViewArticle();
            this.Article2 = new Parser.ViewArticle();
            this.Article3 = new Parser.ViewArticle();
            this.Article4 = new Parser.ViewArticle();
            this.Article5 = new Parser.ViewArticle();
            this.menuButtonSettings = new Parser.MenuButton();
            this.menuButtonSearch = new Parser.MenuButton();
            this.searchBar = new Parser.SearchBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
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
            this.panel1.Controls.Add(this.searchBar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 50);
            this.panel1.TabIndex = 3;
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
            this.panel2.Controls.Add(this.menuButtonSettings);
            this.panel2.Controls.Add(this.menuButtonSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 536);
            this.panel2.TabIndex = 1;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.MainPanel.Controls.Add(this.SearchPanel);
            this.MainPanel.Controls.Add(this.SettingsPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(184, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(685, 536);
            this.MainPanel.TabIndex = 2;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.Article1);
            this.SearchPanel.Controls.Add(this.Article2);
            this.SearchPanel.Controls.Add(this.CountArticle);
            this.SearchPanel.Controls.Add(this.Article3);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Controls.Add(this.Article4);
            this.SearchPanel.Controls.Add(this.NumberPage);
            this.SearchPanel.Controls.Add(this.Article5);
            this.SearchPanel.Controls.Add(this.button2);
            this.SearchPanel.Controls.Add(this.button1);
            this.SearchPanel.Location = new System.Drawing.Point(1, 2);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(680, 532);
            this.SearchPanel.TabIndex = 11;
            // 
            // CountArticle
            // 
            this.CountArticle.AutoSize = true;
            this.CountArticle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountArticle.ForeColor = System.Drawing.Color.White;
            this.CountArticle.Location = new System.Drawing.Point(602, 506);
            this.CountArticle.Name = "CountArticle";
            this.CountArticle.Size = new System.Drawing.Size(15, 17);
            this.CountArticle.TabIndex = 9;
            this.CountArticle.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(502, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Всего статей: ";
            // 
            // NumberPage
            // 
            this.NumberPage.AutoSize = true;
            this.NumberPage.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumberPage.ForeColor = System.Drawing.Color.White;
            this.NumberPage.Location = new System.Drawing.Point(319, 505);
            this.NumberPage.Name = "NumberPage";
            this.NumberPage.Size = new System.Drawing.Size(0, 17);
            this.NumberPage.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(211, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вперед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(685, 536);
            this.SettingsPanel.TabIndex = 10;
            this.SettingsPanel.Visible = false;
            // 
            // Article1
            // 
            this.Article1.ArticleDate = "";
            this.Article1.ArticleText = "";
            this.Article1.ArticleTitle = "";
            this.Article1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article1.Location = new System.Drawing.Point(3, 3);
            this.Article1.Name = "Article1";
            this.Article1.Size = new System.Drawing.Size(655, 93);
            this.Article1.TabIndex = 0;
            // 
            // Article2
            // 
            this.Article2.ArticleDate = "";
            this.Article2.ArticleText = "";
            this.Article2.ArticleTitle = "";
            this.Article2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article2.Location = new System.Drawing.Point(3, 102);
            this.Article2.Name = "Article2";
            this.Article2.Size = new System.Drawing.Size(655, 93);
            this.Article2.TabIndex = 1;
            // 
            // Article3
            // 
            this.Article3.ArticleDate = "";
            this.Article3.ArticleText = "";
            this.Article3.ArticleTitle = "";
            this.Article3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article3.Location = new System.Drawing.Point(3, 201);
            this.Article3.Name = "Article3";
            this.Article3.Size = new System.Drawing.Size(655, 93);
            this.Article3.TabIndex = 2;
            // 
            // Article4
            // 
            this.Article4.ArticleDate = "";
            this.Article4.ArticleText = "";
            this.Article4.ArticleTitle = "";
            this.Article4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article4.Location = new System.Drawing.Point(3, 300);
            this.Article4.Name = "Article4";
            this.Article4.Size = new System.Drawing.Size(655, 93);
            this.Article4.TabIndex = 3;
            // 
            // Article5
            // 
            this.Article5.ArticleDate = "";
            this.Article5.ArticleText = "";
            this.Article5.ArticleTitle = "";
            this.Article5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.Article5.Location = new System.Drawing.Point(3, 399);
            this.Article5.Name = "Article5";
            this.Article5.Size = new System.Drawing.Size(655, 93);
            this.Article5.TabIndex = 4;
            // 
            // menuButtonSettings
            // 
            this.menuButtonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.menuButtonSettings.CustomText = "Settings";
            this.menuButtonSettings.IsActive = false;
            this.menuButtonSettings.Location = new System.Drawing.Point(0, 159);
            this.menuButtonSettings.Name = "menuButtonSettings";
            this.menuButtonSettings.Picture = ((System.Drawing.Image)(resources.GetObject("menuButtonSettings.Picture")));
            this.menuButtonSettings.Size = new System.Drawing.Size(184, 50);
            this.menuButtonSettings.TabIndex = 1;
            // 
            // menuButtonSearch
            // 
            this.menuButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.menuButtonSearch.CustomText = "Search";
            this.menuButtonSearch.IsActive = true;
            this.menuButtonSearch.Location = new System.Drawing.Point(0, 105);
            this.menuButtonSearch.Name = "menuButtonSearch";
            this.menuButtonSearch.Picture = ((System.Drawing.Image)(resources.GetObject("menuButtonSearch.Picture")));
            this.menuButtonSearch.Size = new System.Drawing.Size(184, 50);
            this.menuButtonSearch.TabIndex = 0;
            // 
            // searchBar
            // 
            this.searchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.searchBar.Color = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.searchBar.CustomText = "What are you looking for?";
            this.searchBar.Location = new System.Drawing.Point(248, 8);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(329, 34);
            this.searchBar.TabIndex = 2;
            this.searchBar.Enter += new System.EventHandler(this.bunifuTextbox1_Enter);
            this.searchBar.Leave += new System.EventHandler(this.search_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 586);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SearchBar searchBar;
        private ViewArticle Article5;
        private ViewArticle Article4;
        private ViewArticle Article3;
        private ViewArticle Article2;
        private ViewArticle Article1;
        private System.Windows.Forms.Label NumberPage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label CountArticle;
        private System.Windows.Forms.Label label1;
        private MenuButton menuButtonSearch;
        private System.Windows.Forms.Panel SettingsPanel;
        private MenuButton menuButtonSettings;
        private System.Windows.Forms.Panel SearchPanel;
    }
}

