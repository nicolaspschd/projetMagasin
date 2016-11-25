using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Drawing;
using System.IO;

namespace magasin
{
    static class FTPdownloader
    {
        const string FTPUSERID = "pi";
        const string FTPPASSWORD = "fondue123";
        const string URI = "ftp://10.134.97.69/home/pi/Desktop/ftp/";

        static public Image Download(string fileName)
        {
            FtpWebRequest reqFTP;
            Image tmpImage = null;
            try
            {
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(URI + fileName));
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(FTPUSERID, FTPPASSWORD);
                Console.WriteLine(reqFTP.ToString());
                FtpWebResponse response = reqFTP.GetResponse() as FtpWebResponse;
                Stream ftpStream = response.GetResponseStream();

                tmpImage = Image.FromStream(ftpStream);

                ftpStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
            return tmpImage;
        }

    }
}
