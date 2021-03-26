using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Web_browser
{
    public partial class WEBbrowser : Form
    {
        private int kolPages = 0; //для наследования

        public WEBbrowser()
        {
            InitializeComponent();

            display_window.ContextMenuStrip = contextMenu;
            
            listBox_Bookmarks.Items.AddRange(File.ReadAllLines("Bookmarks.txt"));

            history_Box.Text = File.ReadAllText("History.txt");
        }
        private void WebBrowser_Load(object sender, EventArgs e) // при открытии браузера новая вкладка
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            display_window.TabPages.Add("Новая вкладка");
            display_window.SelectTab(kolPages);
            display_window.SelectedTab.Controls.Add(browser);
            kolPages++;
        }

        private void AddTab_Click(object sender, EventArgs e) //добавление новой вкладки
        {
            WebBrowser browser = new WebBrowser();
            browser.Visible = true;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            browser.DocumentCompleted += browser_DocumentCompleted;

            display_window.TabPages.Add($"Новая вкладка{kolPages}");
            display_window.SelectTab(kolPages);
            display_window.SelectedTab.Controls.Add(browser);
            kolPages++;
        }

        void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            display_window.SelectedTab.Text = ((WebBrowser)display_window.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void SavePage_Click(object sender, EventArgs e)//сохранение страницы на диске
        {
            ((WebBrowser)display_window.SelectedTab.Controls[0]).ShowSaveAsDialog();
        }

        private void Search_Button_Click(object sender, EventArgs e)// поиск
        {
            if (!String.IsNullOrEmpty(SearchString.Text))
            {
                if (SearchString.Text.Contains("https://") || SearchString.Text.Contains("http://"))
                {

                    ((WebBrowser)display_window.SelectedTab.Controls[0]).Navigate(SearchString.Text);
                }
                else
                {
                    Uri uri = new Uri("https://yandex.ru/search/?text=" + SearchString.Text);
                    ((WebBrowser)display_window.SelectedTab.Controls[0]).Navigate(uri);
                }
                File.AppendAllText("History.txt", SearchString.Text + "\n");
                history_Box.Text = File.ReadAllText("History.txt");
            }
        }

        private void SearchString_KeyUp(object sender, KeyEventArgs e)// поиск Enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (SearchString.Text.Contains("https://") || SearchString.Text.Contains("http://"))
                {

                    ((WebBrowser)display_window.SelectedTab.Controls[0]).Navigate(SearchString.Text);
                }
                else
                {
                    Uri uri = new Uri("https://yandex.ru/search/?text=" + SearchString.Text);
                    ((WebBrowser)display_window.SelectedTab.Controls[0]).Navigate(uri);
                }
                File.AppendAllText("History.txt", SearchString.Text + "\n");
                history_Box.Text = File.ReadAllText("History.txt");
            }
        }

        private void Back_Button_Click(object sender, EventArgs e) //кнопка назад
        {
            WebBrowser web = (WebBrowser)display_window.SelectedTab.Controls[0];
            if (web.CanGoBack == true)
            {
                web.GoBack();
            }
            else
            {
                MessageBox.Show("Нет истории просмотров");
            }
        }

        private void Forward_Button_Click(object sender, EventArgs e)//кнопка вперед
        {
            WebBrowser web = (WebBrowser)display_window.SelectedTab.Controls[0];
            if (web.CanGoForward == true)
            {
                web.GoForward();
            }
            else
            {
                MessageBox.Show("Нет истории просмотров");
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)// кнопка обновить
        {
            ((WebBrowser)display_window.SelectedTab.Controls[0]).Refresh();
        }

        private void Stop_Button_Click(object sender, EventArgs e)//остановка загрузки страницы
        {
            ((WebBrowser)display_window.SelectedTab.Controls[0]).Stop();
        }

        private void Home_Button_Click(object sender, EventArgs e)//главная страница
        {
            ((WebBrowser)display_window.SelectedTab.Controls[0]).GoHome();
        }

        private void DelTab_Click(object sender, EventArgs e)//удаление вкладки
        {

            if (display_window.TabPages.Count > 1)
            {
                display_window.TabPages.RemoveAt(display_window.SelectedIndex);
                display_window.SelectTab(display_window.TabPages.Count - 1);
                kolPages--;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Закрыть Web-browser?", "Web-browser", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void AddToBookmarks_Click(object sender, EventArgs e)//добавление закладки 
        {
            File.AppendAllText("Bookmarks.txt", display_window.SelectedTab.Text.ToString()+"\n");
            listBox_Bookmarks.Items.Add(display_window.SelectedTab.Text.ToString());
        }

        private void удалитьЗакладкуToolStripMenuItem_Click(object sender, EventArgs e)//удаление закладки
        {
            listBox_Bookmarks.Items.RemoveAt(listBox_Bookmarks.SelectedIndex);
        }

        private void SearchString_TextChanged(object sender, EventArgs e)// подсказка при вводе такста 
        {
            try
            {
                string[] his_search = File.ReadAllLines("History.txt");
                AutoCompleteStringCollection a = new AutoCompleteStringCollection();
                foreach (string ste in his_search)
                {
                    string ste2 = ste.Replace("yandex: ", "").Trim();
                    a.Add(ste2);
                }
                SearchString.AutoCompleteCustomSource = a;
            }
            catch (Exception){ }
        }

        private void CleanHistory_Click(object sender, EventArgs e)//очистить историю
        {
            File.WriteAllText("History.txt", "");
            history_Box.Text = File.ReadAllText("History.txt");
        }
    }
}
