namespace Web_browser
{
    partial class WEBbrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WEBbrowser));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Home_Button = new System.Windows.Forms.ToolStripButton();
            this.Back_Button = new System.Windows.Forms.ToolStripButton();
            this.Forward_Button = new System.Windows.Forms.ToolStripButton();
            this.Update_Button = new System.Windows.Forms.ToolStripButton();
            this.Stop_Button = new System.Windows.Forms.ToolStripButton();
            this.SearchString = new System.Windows.Forms.ToolStripTextBox();
            this.Search_Button = new System.Windows.Forms.ToolStripButton();
            this.AddTab = new System.Windows.Forms.ToolStripButton();
            this.DelTab = new System.Windows.Forms.ToolStripButton();
            this.AddToBookmarks = new System.Windows.Forms.ToolStripButton();
            this.display_window = new System.Windows.Forms.TabControl();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SavePage = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.History_Bookmarks = new System.Windows.Forms.TabControl();
            this.History = new System.Windows.Forms.TabPage();
            this.history_Box = new System.Windows.Forms.RichTextBox();
            this.CleanHistory = new System.Windows.Forms.Button();
            this.Bookmarks = new System.Windows.Forms.TabPage();
            this.listBox_Bookmarks = new System.Windows.Forms.ListBox();
            this.contextMenuBookmarks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьЗакладкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.History_Bookmarks.SuspendLayout();
            this.History.SuspendLayout();
            this.Bookmarks.SuspendLayout();
            this.contextMenuBookmarks.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Home_Button,
            this.Back_Button,
            this.Forward_Button,
            this.Update_Button,
            this.Stop_Button,
            this.SearchString,
            this.Search_Button,
            this.AddTab,
            this.DelTab,
            this.AddToBookmarks});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Home_Button
            // 
            this.Home_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home_Button.Image = ((System.Drawing.Image)(resources.GetObject("Home_Button.Image")));
            this.Home_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Home_Button.Name = "Home_Button";
            this.Home_Button.Size = new System.Drawing.Size(23, 22);
            this.Home_Button.Text = "Домашняя страница";
            this.Home_Button.Click += new System.EventHandler(this.Home_Button_Click);
            // 
            // Back_Button
            // 
            this.Back_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Back_Button.Image = ((System.Drawing.Image)(resources.GetObject("Back_Button.Image")));
            this.Back_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(23, 22);
            this.Back_Button.Text = "Назад";
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Forward_Button
            // 
            this.Forward_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Forward_Button.Image = ((System.Drawing.Image)(resources.GetObject("Forward_Button.Image")));
            this.Forward_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(23, 22);
            this.Forward_Button.Text = "Вперёд";
            this.Forward_Button.Click += new System.EventHandler(this.Forward_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Update_Button.Image = ((System.Drawing.Image)(resources.GetObject("Update_Button.Image")));
            this.Update_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(23, 22);
            this.Update_Button.Text = "Обновить";
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Stop_Button.Image = ((System.Drawing.Image)(resources.GetObject("Stop_Button.Image")));
            this.Stop_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(23, 22);
            this.Stop_Button.Text = "Остановить загрузку";
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // SearchString
            // 
            this.SearchString.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.SearchString.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchString.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchString.Name = "SearchString";
            this.SearchString.Size = new System.Drawing.Size(600, 25);
            this.SearchString.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchString_KeyUp);
            this.SearchString.TextChanged += new System.EventHandler(this.SearchString_TextChanged);
            // 
            // Search_Button
            // 
            this.Search_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Search_Button.Image = ((System.Drawing.Image)(resources.GetObject("Search_Button.Image")));
            this.Search_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.Size = new System.Drawing.Size(23, 22);
            this.Search_Button.Text = "Поиск";
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // AddTab
            // 
            this.AddTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTab.Image = ((System.Drawing.Image)(resources.GetObject("AddTab.Image")));
            this.AddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTab.Name = "AddTab";
            this.AddTab.Size = new System.Drawing.Size(23, 22);
            this.AddTab.Text = "Добавить новую вкладку";
            this.AddTab.Click += new System.EventHandler(this.AddTab_Click);
            // 
            // DelTab
            // 
            this.DelTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelTab.Image = ((System.Drawing.Image)(resources.GetObject("DelTab.Image")));
            this.DelTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelTab.Name = "DelTab";
            this.DelTab.Size = new System.Drawing.Size(23, 22);
            this.DelTab.Text = "Удалить вкладку";
            this.DelTab.Click += new System.EventHandler(this.DelTab_Click);
            // 
            // AddToBookmarks
            // 
            this.AddToBookmarks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToBookmarks.Image = ((System.Drawing.Image)(resources.GetObject("AddToBookmarks.Image")));
            this.AddToBookmarks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToBookmarks.Name = "AddToBookmarks";
            this.AddToBookmarks.Size = new System.Drawing.Size(23, 22);
            this.AddToBookmarks.Text = "Добавить страницу в Закладки ";
            this.AddToBookmarks.Click += new System.EventHandler(this.AddToBookmarks_Click);
            // 
            // display_window
            // 
            this.display_window.Dock = System.Windows.Forms.DockStyle.Right;
            this.display_window.Location = new System.Drawing.Point(128, 25);
            this.display_window.Name = "display_window";
            this.display_window.SelectedIndex = 0;
            this.display_window.Size = new System.Drawing.Size(794, 425);
            this.display_window.TabIndex = 1;
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavePage});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(178, 26);
            // 
            // SavePage
            // 
            this.SavePage.Name = "SavePage";
            this.SavePage.Size = new System.Drawing.Size(177, 22);
            this.SavePage.Text = "Сохранить на диск";
            this.SavePage.Click += new System.EventHandler(this.SavePage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.History_Bookmarks);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 425);
            this.panel1.TabIndex = 2;
            // 
            // History_Bookmarks
            // 
            this.History_Bookmarks.Controls.Add(this.History);
            this.History_Bookmarks.Controls.Add(this.Bookmarks);
            this.History_Bookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History_Bookmarks.Location = new System.Drawing.Point(0, 0);
            this.History_Bookmarks.Name = "History_Bookmarks";
            this.History_Bookmarks.SelectedIndex = 0;
            this.History_Bookmarks.Size = new System.Drawing.Size(126, 425);
            this.History_Bookmarks.TabIndex = 0;
            // 
            // History
            // 
            this.History.Controls.Add(this.history_Box);
            this.History.Controls.Add(this.CleanHistory);
            this.History.Location = new System.Drawing.Point(4, 22);
            this.History.Name = "History";
            this.History.Padding = new System.Windows.Forms.Padding(3);
            this.History.Size = new System.Drawing.Size(118, 399);
            this.History.TabIndex = 0;
            this.History.Text = "История  ";
            this.History.UseVisualStyleBackColor = true;
            // 
            // history_Box
            // 
            this.history_Box.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.history_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.history_Box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.history_Box.Location = new System.Drawing.Point(3, 3);
            this.history_Box.Name = "history_Box";
            this.history_Box.ReadOnly = true;
            this.history_Box.Size = new System.Drawing.Size(112, 370);
            this.history_Box.TabIndex = 2;
            this.history_Box.Text = "";
            // 
            // CleanHistory
            // 
            this.CleanHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CleanHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanHistory.Location = new System.Drawing.Point(3, 373);
            this.CleanHistory.Name = "CleanHistory";
            this.CleanHistory.Size = new System.Drawing.Size(112, 23);
            this.CleanHistory.TabIndex = 1;
            this.CleanHistory.Text = "Очистить историю";
            this.CleanHistory.UseVisualStyleBackColor = true;
            this.CleanHistory.Click += new System.EventHandler(this.CleanHistory_Click);
            // 
            // Bookmarks
            // 
            this.Bookmarks.Controls.Add(this.listBox_Bookmarks);
            this.Bookmarks.Cursor = System.Windows.Forms.Cursors.Default;
            this.Bookmarks.Location = new System.Drawing.Point(4, 22);
            this.Bookmarks.Name = "Bookmarks";
            this.Bookmarks.Padding = new System.Windows.Forms.Padding(3);
            this.Bookmarks.Size = new System.Drawing.Size(118, 399);
            this.Bookmarks.TabIndex = 1;
            this.Bookmarks.Text = "Закладки";
            this.Bookmarks.UseVisualStyleBackColor = true;
            // 
            // listBox_Bookmarks
            // 
            this.listBox_Bookmarks.ContextMenuStrip = this.contextMenuBookmarks;
            this.listBox_Bookmarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_Bookmarks.FormattingEnabled = true;
            this.listBox_Bookmarks.Location = new System.Drawing.Point(3, 3);
            this.listBox_Bookmarks.Name = "listBox_Bookmarks";
            this.listBox_Bookmarks.Size = new System.Drawing.Size(112, 393);
            this.listBox_Bookmarks.TabIndex = 0;
            // 
            // contextMenuBookmarks
            // 
            this.contextMenuBookmarks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьЗакладкуToolStripMenuItem});
            this.contextMenuBookmarks.Name = "contextMenuStrip1";
            this.contextMenuBookmarks.Size = new System.Drawing.Size(170, 26);
            // 
            // удалитьЗакладкуToolStripMenuItem
            // 
            this.удалитьЗакладкуToolStripMenuItem.Name = "удалитьЗакладкуToolStripMenuItem";
            this.удалитьЗакладкуToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.удалитьЗакладкуToolStripMenuItem.Text = "Удалить закладку";
            this.удалитьЗакладкуToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗакладкуToolStripMenuItem_Click);
            // 
            // WEBbrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.display_window);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WEBbrowser";
            this.Text = "Web-browser";
            this.Load += new System.EventHandler(this.WebBrowser_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.History_Bookmarks.ResumeLayout(false);
            this.History.ResumeLayout(false);
            this.Bookmarks.ResumeLayout(false);
            this.contextMenuBookmarks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Back_Button;
        private System.Windows.Forms.ToolStripButton Forward_Button;
        private System.Windows.Forms.ToolStripButton Update_Button;
        private System.Windows.Forms.ToolStripButton Stop_Button;
        private System.Windows.Forms.ToolStripTextBox SearchString;
        private System.Windows.Forms.ToolStripButton Search_Button;
        private System.Windows.Forms.ToolStripButton Home_Button;
        private System.Windows.Forms.TabControl display_window;
        private System.Windows.Forms.ToolStripButton AddTab;
        private System.Windows.Forms.ToolStripButton DelTab;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem SavePage;
        private System.Windows.Forms.ToolStripButton AddToBookmarks;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl History_Bookmarks;
        private System.Windows.Forms.TabPage History;
        private System.Windows.Forms.TabPage Bookmarks;
        private System.Windows.Forms.ListBox listBox_Bookmarks;
        private System.Windows.Forms.ContextMenuStrip contextMenuBookmarks;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗакладкуToolStripMenuItem;
        private System.Windows.Forms.RichTextBox history_Box;
        private System.Windows.Forms.Button CleanHistory;
    }
}

