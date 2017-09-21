using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoxBooru
{
    public class Base
    {
        public static void ErrorReporting(Exception ex)
        {
            //throw (ex);


            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Fatal(ex);



        }
    }
}
