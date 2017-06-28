using static System.Console;
// Import Initial Sample
using AzureLibrary;

// Import EpplusSample
using AzureLibrary.EpplusSample.Sample01;
using AzureLibrary.EpplusSample.Sample02;

using AzureLibrary.DBModel.DBTools;

namespace AzureMainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ------ Initial Sample Code ------ 
            // WriteLine($"The answer is {new Thing().Get(19, 23)}");
            
            // ------ EPPLUS Sample Code ------ 
            // Sample01 model_demo01 = new Sample01();
            // model_demo01.RunSample1();

            // Sample02 model_demo02 = new Sample02();
            // model_demo02.RunSample2();

            DBTools db = new DBTools();
            // db.storeData();
            // db.getData();
            db.DataTableSFToExcelFile("DB_To_Excel.xlsx");
            WriteLine("Done");
        }
    }
}
