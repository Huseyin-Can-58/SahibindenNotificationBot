using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Xml.Schema;
using Keys = OpenQA.Selenium.Keys;

namespace SahibindenBot
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {

        //int telsayi = 0;
        //IWebDriver[] driver = new FirefoxDriver[5000];
        //IWebDriver driver = new ChromeDriver();
        IWebDriver driver = null;
        IWebDriver wpdriver = null;
        bool acik = false;
        int beklemesuresi = 5000;
        Thread basla;
        string baslik = "";
        string link = "";
        string fiyat = "";

        string kont = "";
        bool ilkkez = false;
        void sifirla()
        {
            baslik = "";
            fiyat = "";
            link = "";
        }
        void kontrolebasla()
        {
            var driverServicewp = ChromeDriverService.CreateDefaultService();
            driverServicewp.HideCommandPromptWindow = true;
            driver = new ChromeDriver(driverServicewp);
            //driver = new ChromeDriver();
            while (true)
            { 
                for(int i = 0; i<richTextBox3.Lines.Length; i++)
                {
                    if (!String.IsNullOrEmpty(richTextBox3.Lines[i]))
                    {

                        driver.Navigate().GoToUrl(richTextBox3.Lines[i]);
                        driver.Navigate().Refresh();
                        Thread.Sleep(200);
                        var ilanlar = driver.FindElement(By.ClassName("searchResultsRowClass")).FindElements(By.TagName("tr"));
                        for (int y = 0; y < ilanlar.Count; y++)
                        {
                            try
                            {

                                baslik = ilanlar[y].FindElement(By.ClassName("searchResultsTitleValue")).Text;
                                link = ilanlar[y].FindElement(By.TagName("a")).GetAttribute("href");
                                fiyat = ilanlar[y].FindElement(By.ClassName("searchResultsPriceValue")).Text;
                                //MessageBox.Show(baslik + " ---------" + link + " --------" + fiyat);

                                if (ilkkez == false)
                                {
                                    kont += baslik;
                                }
                                else
                                {
                                    if (!kont.Contains(baslik))
                                    {
                                        kont += baslik;
                                        for (int m = 0; m < richTextBox2.Lines.Length; m++)
                                        {

                                            string wplink = "https://web.whatsapp.com/send?phone=90" + richTextBox2.Lines[m].ToString();
                                            try
                                            {
                                                wpdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                                                IJavaScriptExecutor js = (IJavaScriptExecutor)wpdriver;
                                                js.ExecuteScript("var element = document.getElementById('eklelink');element.parentNode.removeChild(element);");
                                            }
                                            catch (Exception)
                                            { }
                                            try
                                            {
                                                string numaralinkkoy = richTextBox4.Text;
                                                numaralinkkoy = numaralinkkoy.Replace("{num}", wplink);
                                                IJavaScriptExecutor js = (IJavaScriptExecutor)wpdriver;
                                                wpdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                                                js.ExecuteScript(numaralinkkoy);
                                            }
                                            catch (Exception)
                                            { }
                                            try
                                            {
                                                wpdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                                                wpdriver.FindElement(By.Id("eklelink")).Click();
                                            }
                                            catch (Exception)
                                            { }

                                            richTextBox1.Text += "✅ Başlık ✅" + baslik + "\n";
                                            richTextBox1.Text += "✅ Link ✅" + link + "\n";
                                            richTextBox1.Text += "✅ Fiyat ✅" + fiyat + "\n";
                                            this.Invoke((MethodInvoker)(() => Clipboard.SetText(richTextBox1.Text)));

                                            Thread.Sleep(500);
                                            wpdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                                            wpdriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]")).Clear();
                                            wpdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                                            wpdriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]")).SendKeys(Keys.Control + "v");
                                            Thread.Sleep(1000);
                                            wpdriver.FindElement(By.XPath("/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]")).SendKeys(Keys.Enter);
                                            this.Invoke((MethodInvoker)(() => Clipboard.Clear()));
                                        }
                                    }
                                }
                            }
                            catch (Exception)
                            {

                            }
                            sifirla();
                        }
                        if (richTextBox3.Lines.Length > 1)
                        {
                            Thread.Sleep(beklemesuresi);
                        }
                    }
                }
                Thread.Sleep(beklemesuresi);
                ilkkez = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void driveracilis()
        {

            try
            {
                var driverService = ChromeDriverService.CreateDefaultService();
                driverService.HideCommandPromptWindow = true;
                /*driver[telsayi].Navigate().GoToUrl("https://web.whatsapp.com");
                driver[telsayi].Manage().Cookies.DeleteAllCookies();*/
                wpdriver = new ChromeDriver(driverService);
                wpdriver.Navigate().GoToUrl("https://web.whatsapp.com");
                wpdriver.Manage().Cookies.DeleteAllCookies();
                acik = true;
                //telsayi++;
                //this.Invoke((MethodInvoker)(() => label4.Text = (telsayi).ToString()));
            }

            catch (Exception)
            {
                //telsayi--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox2.Text = Properties.Settings.Default.gönderimnolari;
        }

        private void WhatsappAdd_Click(object sender, EventArgs e)
        {
            if(acik == false)
            {
                Thread islem = new Thread(new ThreadStart(driveracilis));
                islem.Start();
            }
            else
            {
                MessageBox.Show("WhatsApp öncesinde eklendi!");
            }

        }

        private void LinkAdd_Click(object sender, EventArgs e)
        {
            linkler li = new linkler();
            li.Show();
        }

        private void TimeSettings_Click(object sender, EventArgs e)
        {
            sure sur = new sure();
            sur.Show();

        }

        private void Run_Click(object sender, EventArgs e)
        {
            //sure gonderim nolari
            try
            {
                beklemesuresi = int.Parse(Properties.Settings.Default.sure) * 1000;
                richTextBox3.Text = Properties.Settings.Default.linkler;
                Properties.Settings.Default.gönderimnolari = richTextBox2.Text;
                Properties.Settings.Default.Save();
            }
            catch(Exception){

            }
            if (richTextBox3.Text.Length > 10 && beklemesuresi >= 1000 && acik == true)
            {
                basla = new Thread(kontrolebasla);
                basla.Start();
            }
            else
            {
                MessageBox.Show("Link ekleyiniz, Whatsapp bağlayınız veya süreyi kontrol ediniz!");
            }

        }

        private void durdurbutton_Click(object sender, EventArgs e)
        {
            basla.Suspend();
        }

        private void DevamButton_Click(object sender, EventArgs e)
        {
            basla.Resume();
        }
    }
}
