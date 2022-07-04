using Microsoft.Win32;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace moin
{
    class SeleniumHelper
    {
        public IWebDriver driver { get; private set; } = new FirefoxDriver();
        private string FilePath{ get; } = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\moin.png";
        public SeleniumHelper()
        {
            driver.Url = @"https://images.google.com";
            IWebElement btn = driver.FindElement(By.Id("L2AGLb"));
            btn.Submit();
        }

        public void Submit()
        {
            ImageConverter();
            IWebElement btn2 = driver.FindElement(By.ClassName("ZaFQO"));
            btn2.Click();
            //IWebElement tb = driver.FindElement(By.Id("Ycyxxc"));
            //tb.SendKeys(@"https://upload.wikimedia.org/wikipedia/commons/thumb/4/4f/Malus-domestica-blomstring.JPG/300px-Malus-domestica-blomstring.JPG");
            //IWebElement btn_submit = driver.FindElement(By.Id("RZJ9Ub"));
            //btn_submit.Click();
            IWebElement btn4 = driver.FindElement(By.Id("awyMjb"));
            btn4.SendKeys(FilePath);
        }

        private void ImageConverter()
        {
            if (Clipboard.ContainsImage())
            {
                BitmapSource image = Clipboard.GetImage();
                using (var fileStream = new FileStream(FilePath, FileMode.Create))
                {
                    BitmapEncoder encoder = new PngBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(image));
                    encoder.Save(fileStream);
                }
            }
        }
    }
}
