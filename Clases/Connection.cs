using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transactions_DC.Clases
{
    internal class Connection
    {






        public bool pingging(string host)
        {
            // Crea un proceso para ejecutar el comando ping en Windows
            Process process = new Process();
            process.StartInfo.FileName = "ping";
            process.StartInfo.Arguments = $"-n 1 {host}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.CreateNoWindow = true;

            // Inicia el proceso
            process.Start();

            // Lee la salida estándar y la salida de error
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            // Espera a que el proceso termine
            process.WaitForExit();

            // Verifica el resultado
            if (output.Contains("Received = 1,"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
