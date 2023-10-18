using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transactions_DC.Clases;
using static System.Windows.Forms.AxHost;

namespace Transactions_DC
{
    internal class Files
    {
        private string pathTR { get; set; }

        private string pos { get; set; }

        private bool ping { get; set; }





        // Constructor de la clase
        public Files(string pos)
        {
            this.pos = pos;
            Connection conn = new Connection();
            this.ping = conn.pingging(this.pos);
            this.pathTR = $@"\\{this.pos}\c$\MerchantConnectMulti\log\";

        }




        public string[] ConvertFile()
        {
            DateTime now = DateTime.Now;



            if (this.ping)
            {


                string year = now.Year.ToString();
                string month = now.Month.ToString("00");
                string day = now.Day.ToString("00");
                string fileName = year + month + day;

                string filePath = Path.Combine(this.pathTR, $"{fileName}.rcp");


                if (File.Exists(filePath))
                {

                    string localFile = Path.Combine(Path.GetTempPath(), $"{fileName}.txt");
                    File.Copy(filePath, localFile);

                    string fileContent = File.ReadAllText(localFile);
                    string[] separators = { "----------------------------------------\r\n-----   E N D   O F   E N T R Y    -----\r\n----------------------------------------" };
                    string[] fragments = fileContent.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    File.Delete(localFile);

                    return fragments;
                }
                else
                {
                    return new string[] { "error path" } ;
                }
            }else 
            {

                return new string[] { "error conn" } ;
            }

        }

    }



}
