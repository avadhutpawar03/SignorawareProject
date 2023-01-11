using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Signoraware.Utilities
{
    public class DataSource
    {
       
        public static object[] InvalidLoginData()
        {
            string[] dataset1 = new string[3];
            dataset1[0] = "chetanpp@gmail.com";
            dataset1[1] = "chetan123";
            dataset1[2] = "The account sign-in was incorrect";




            string[] dataset2 = new string[3];
            dataset2[0] = "ChetanKK@gmail.com";
            dataset2[1] = "chet123";
            dataset2[2] = "The account sign-in was incorrect";




         


            object[] allDataSet = new object[2];
            allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;
           
            return allDataSet;
        }



        public static object[] ValidEmployeeData()
        {
            string[] dataset1 = new string[7];
            dataset1[0] = "Admin";
            dataset1[1] = "admin123";
            dataset1[2] = "john";
            dataset1[3] = "w";
            dataset1[4] = "wick";
            dataset1[5] = "//h6[text()='john wick']";
            dataset1[6] = "john wick";





            string[] dataset2 = new string[7];
            dataset2[0] = "Admin";
            dataset2[1] = "admin123";
            dataset2[2] = "saul";
            dataset2[3] = "g";
            dataset2[4] = "goodman";
            dataset2[5] = "//h6[text()='saul goodman']";
            dataset2[6] = "saul goodman";




            object[] allDataSet = new object[2];
            allDataSet[0] = dataset1;
            allDataSet[1] = dataset2;



            return allDataSet;


        }
       public static object[] InvalidLoginData2()
        {
           object[] data = ExcelUtil.GetSheetIntoObjectArray(@"C:\Users\avadhutp\Desktop\C#\AutomationSignoraware\Signoraware\TestData\TestData.xlsx","InvalidLoginData");
            return data;
        }
        //public static object[] ValidEmployeeData2()
        //{
         //   object[] data = ExcelUtils.GetSheetIntoObjectArray(@"C:\Users\avadhutp\Desktop\C#\AutomationFramework\EmployeeMangagement\Base\TestData\Orange.xlsx", "InvalidLoginTest");
          //  return data;
        //}

    }
}
    

