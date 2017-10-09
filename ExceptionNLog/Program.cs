using NLog;
using System;
namespace LogDemo
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("Entering: " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            logger.Info("Calling test1");
            test1(5, 5);
            logger.Info("Returned from test1");
            logger.Info("Calling test2");
            test2();
            logger.Info("Returned from test2");
            logger.Trace("Exiting: " + System.Reflection.MethodBase.GetCurrentMethod().Attributes);
        }

        static void test1(int i, int x)
        {
            logger.Trace("Entering: " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
            logger.Trace("Exiting: " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }

        static void test2()
        {
            logger.Trace("Entering: " + System.Reflection.MethodBase.GetCurrentMethod().Name);
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                // mangler log
            }
            logger.Trace("Exiting: " + System.Reflection.MethodBase.GetCurrentMethod().Name);
        }
    }
}

