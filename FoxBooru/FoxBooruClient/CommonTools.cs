

using System.Security.Cryptography;
using System.Text;

namespace FoxBooruClient
{
    public class CommonTools
    {
        public static void ErrorReporting(Exception ex)
        {
            //throw (ex);


            NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Fatal(ex);



        }
        public static string getHash(byte[] cont)
        {
            try
            {
                string ap = null;

                if (cont != null)
                {
                    StringBuilder sBuilder = new StringBuilder();
                    using (var md5 = MD5.Create())
                    {
                        var data = md5.ComputeHash(cont);
                        for (int i = 0; i < data.Length; i++)
                        {
                            sBuilder.Append(data[i].ToString("x2"));
                            // sBuilder.Append(data[i].ToString());
                        }
                    }
                    ap = sBuilder.ToString();

                }
                return ap;


            }
            catch (Exception ex)
            {

                ErrorReporting(ex);
                return null;
            }
        }
    }
}