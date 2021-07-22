using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpNetCore
{
    public class Tests : DriverHelper
// Inheritance gia na parei to Driver poy exoyme sto DriverHelper
    {

//        public static IWebDriver Driver;
// Static gia na mporei na ton blepei to custom control. (An kai sto static den theoreitai o  kalyteros tropos)
// To phga sto DriverHelper

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            // Grafo keimeno sto pedio ths formas.
            /*
            <input name="ctl00$ContentPlaceHolder1$Meal" id="ContentPlaceHolder1_Meal" class="awe-val awe-autocomplete awe-txt" type="text" autocomplete="off" placeholder="try o">
             */

            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();
            /*
            <label class="awe-label"><input type="checkbox" value="183" name="ctl00$ContentPlaceHolder1$ChildMeal1" style="display:none"><div class="o-con">Celery</div><div tabindex="0" class="o-chk "><div class="o-chkc"><div class="o-chkico"></div></div></div></label>

             // =	Selects nodes in the document from the current node that match the selection no matter where they are 
            pairnei ena input me name ctl00$ContentPlaceHolder1$ChildMeal1 
            / 	Selects from the root node
           Koitaei ta Siblings (Nodes that have the same parent) kai epilexei ayto me to keimeno Celery.
             */

            /*
            Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']")).Clear();
            Adeiazo to keimeno pou yparxei hdh apo combo box poy exei men menu me epiloges alla moy 
            dinei kai th dynatothta na grapso thn epilogh moy.
            */

//             CustomControl control = new CustomControl();
// control.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
// Etsi to kano initialized an den einai static.

            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo","Almond");



 //           IWebElement comboControl = Driver.FindElement(By.XPath("//input[@id='ContentPlaceHolder1_AllMealsCombo-awed']"));
 // To ebala sto CustomControl.

            // Bazo olo to combo control se mia variable.
            // Mporo na to grapso kai os "var comboControl" alla kalytera na exei to sosto type.

            /*
             * <div class="awe-display combobox"><div class="valCont" style="display: none;"><input type="radio" value="169" name="itemContentPlaceHolder1_AllMealsCombo" checked="checked" class="o-itmv"></div><div class="o-dd"><div class="o-disp o-ldngp"><div class="awe-loading"><span></span></div><input type="text" class="awe-txt o-cbxt o-src" size="1" autocomplete="off" id="ContentPlaceHolder1_AllMealsCombo-awed" placeholder="please select" aria-invalid="false"><button type="button" class="o-cbxbtn o-ddbtn awe-btn o-btn" aria-label="open" tabindex="-1"><div class="o-slbtn"><i class="o-caret"></i></div></button></div></div></div>
             <input type="text" class="awe-txt o-cbxt o-src" size="1" autocomplete="off" id="ContentPlaceHolder1_AllMealsCombo-awed" placeholder="please select" aria-invalid="false">
             */

//            comboControl.Clear();
//            comboControl.SendKeys("Almond");
//            Driver.FindElement(By.XPath("//div[@id='ContentPlaceHolder1_AllMealsCombo-dropmenu']//li[text()='Almond']")).Click();
            // Ta ebala sto CustomControl.

            /* H sosth grafh einai Almonds opote moy bgazei 2 epiloges kai kano inspect thn Almond kai blepo pos einai:
            < li class="o-itm o-v o-cmbi" data-val="Almond">Almond</li>
            */

            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}