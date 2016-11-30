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
        const string FTPUSERID = "ProjetMagasin";
        const string FTPPASSWORD = "deuXsept";
        const string URI = "ftp://ProjetMagasin@10.134.96.109/ProjetMagasin/";

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
