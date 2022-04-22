using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace NUnitAutomation
{
    public class Tests                      // Main class 
    {
        ////                                      Setup us removed, soits neater  

        //[Test]
        //public void Test1()                // Main method  , dont change name call othermethods here 
        //{
        //    getResult(1, 2);
        //}

        //public int getResult(int num1, int num2)   //  remove Void -when passing values within ()   
        //{
        //    return num1 + num2;                    // retun dont have ;

        //}

        //public int getResult2(int num1, int num2) => num1 + num2;  // Lambda

        //[Test]
        //public void Test2()
        //{                                               // always run console writelline in debug mode for NUnity
        //    System.Console.WriteLine("I am a genius");  //Result should be displayed in \\test detail sumary winodow 
        //}

        //[Test]                                        // Add teast abloe class-  When adding additinal class 
        //public void Test3()
        //{
        //    var result = getResult(1, 2);             // varaiable has ;
        //    System.Console.WriteLine(result.ToString());  //if u put result in "" it will rrn result
        //}


        //[Test]
        //public void Test4()
        //{
        //    Assert.Fail();                       // fails test
        //}
    }


    public class Tests2         //when to use public  privat or protected static

    // *Public static means one instance that is ReaderWriterLock usable 
    {                                                    //global variable icreated insde of one method 

        public static IWebDriver? driver;                // Globalisation b4 method
        ChromeOptions? options;                          // Globalisation b4 method
        public static string url = "https://www.shein.co.uk/";
        //public static string url1 = "https://demoqa.com/";    // you can store Url in resource file 
        //public static string url3 = "http://demo.automationtesting.in/Register.html";


        // above is commented out course we creates a reource file for the URLS if using URL resource file 

        [Test]
        public void Practice1()                       //  1st  structure and run rest then modify
        {

            options = new ChromeOptions();            // Innitialise option same as Iweb Driver 
            options.AddArguments("start-maximised");  // OneTimeSetUpAttribute arguments                                        //options.AddArgument("start-maximised");
                                                      //options.AddArguments("start-maximised", "History"); // 2 argumentsstart and go to history
                                                      // abover added b4 new chrome driver
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl(url);

            //Thread.Sleep(3000);                 //  Basic way - mini secs - faster - used whn its absolutely necessay 

            Thread.Sleep(TimeSpan.FromSeconds(3));  //   secs- using

            //explicit ways - Ideal  for work nd assesment 

            driver.Navigate().Back();

            driver.Navigate().Refresh();           // all above written of one method for global 
        }

        [Test]                                    // another method
        public void Practice2()                  // reuable 
        {
            options = new ChromeOptions();
            options.AddArgument("start-maximised");

            driver = new ChromeDriver(options);  //only need this , dont need to declare global for other methods

            Thread.Sleep(TimeSpan.FromSeconds(3));

            driver.Navigate().GoToUrl(EnvironmentURLs.DemoQA);
            driver.Quit();
        }

        // Using different URL-  declare global url for ythe other url
        [Test]                                       // another method
        public void Practice3()
        {

            options = new ChromeOptions();
            options.AddArgument("start-maximised");

            driver = new ChromeDriver(options);  //only need this , dont need to declare global for other methods

            Thread.Sleep(TimeSpan.FromSeconds(5));

            driver.Navigate().GoToUrl(EnvironmentURLs.DemoRegistration);

            Thread.Sleep(TimeSpan.FromSeconds(5));

            driver.Quit();





        }



    }


 } 
    
//  Cross Brower Testing
 








 


 





 








                                               
        
            
            
            


        


        

        
         



        

       



        

        
    

