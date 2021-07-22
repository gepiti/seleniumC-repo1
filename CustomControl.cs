using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCsharpNetCore
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox (string controlName, string value)
// Gia na diaxeirizomai ta Combo Boxes.
// Static epeidh o Driver pou xrhsimopoiei einai static.
        {

//            IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
// To allazo me interpolation gia na diabazei to idio string se diaforetika shmeia.
            IWebElement comboControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));

            comboControl.Clear();
//            comboControl.SendKeys("Almond");
            comboControl.SendKeys(value);
            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{value}']")).Click();

        }
    }
}
