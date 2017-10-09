using NLog;
using System;

namespace Module09_ExceptionHandling
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            
            try
            {
                //F1();   // global fejlhåndtering...
                Run();
            }
            catch (Exception ex)
            {

                logger.Error(ex);
                // log...
                // redirect
                Console.WriteLine(ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine(ex.InnerException.Message);
                }

            }
            finally
            {
                Console.WriteLine("Kører altid");
            }


        }

        static void Run()
        {
            F1();
        }
        static void F1()
        {
            F2();
        }
        static void F2()
        {
            F3();
        }
        static void F3()
        {
            Dyr d = null;
            Console.WriteLine(d.ToString());
        }

    }

    class Dyr { }

}
