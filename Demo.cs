using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Day4Demo
{
    internal class Demo
    {

        public string name; // not initialised. by default NULL
        public int count = 300;
        public void CheckName()
        {
            try 
            {
                if (name.Contains("aditya"))
                {
                    Console.WriteLine("name present");
                }

                else
                {
                    Console.WriteLine("Name not present");
                }
            }

            catch(Exception ex) 
            {
                Console.WriteLine("Exception Name: {0}", ex.Message);
                Console.WriteLine("Method Name : {0}", ex.TargetSite);
                Console.WriteLine("Project name: {0}", ex.Source);
            }
            

        }
        public void CheckData()
        {
            try
            {
                int[] numArrays = { 10, 20, 30, 40, 50 };

                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine(numArrays[i]);
                }
            }

            catch (NoSuchProductFoundException ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message); // inbuilt 
                Console.WriteLine("Method Name : {0}", ex.TargetSite);
                Console.WriteLine("Project name: {0}", ex.Source);
            }

            //catch (Exception ex1)
            //{
            //    Console.WriteLine("{0}", ex1.Message);
            //}

            
        }
    }
}
