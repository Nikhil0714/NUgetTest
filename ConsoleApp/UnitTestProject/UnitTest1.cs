using System.IO;
using System;

namespace UnitTestProject
{
    
    public class UnitTest1
    {
        private const string Expected = "Hello World!";

   
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); 
                ConsoleApp.Program.Main();

                var result = sw.ToString().Trim();
                
            }
        }
    }
}