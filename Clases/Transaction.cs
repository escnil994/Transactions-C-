using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transactions_DC.Clases;

namespace Transactions_DC
{
    internal class Transaction : ITransation
    {
        public string amount { get; set; }
        public string cardNumber { get; set; }
        public string cardType { get; set; }
        public string authorization { get; set; }
        public string reference { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string responseMessage { get; set; }
        public string mrc { get; set; }
        public string trm { get; set; }
        public string sequential { get; set; }

        public string error { get; set; } 



        public List<Dictionary<string, string>> TransactionsLists = new List<Dictionary<string, string>>();






        public void convertData(string pos)
        {

             Files conn = new Files(pos);

            this.error = conn.ConvertFile()[0].ToString();

            if (this.error != "error path" || this.error != "error conn")
            {

                string[] fragments = conn.ConvertFile();


                int fragmentIndex = 0; // Cambia el índice según el fragmento que desees



                while (fragmentIndex < fragments.Length - 1)
                {




                    if (fragmentIndex >= 0 && fragmentIndex < fragments.Length)
                    {

                        string selectedFragment = fragments[fragmentIndex];
                        string[] linesInFragment = selectedFragment.Split('\n');

                        // Crear un diccionario para almacenar los datos del fragmento
                        Dictionary<string, string> fragmentDictionary = new Dictionary<string, string>();

                        foreach (string line in linesInFragment)
                        {
                            // Dividir cada línea en clave y valor (por ejemplo, asumiendo que las líneas son "clave: valor")
                            string[] parts = line.Trim().Split(':');
                            if (parts.Length == 2)
                            {
                                string key = parts[0].Trim();
                                string value = parts[1].Trim();
                                fragmentDictionary[key] = value;
                            }
                            else if (parts[0] == "TIM")
                            {
                                string linea = line;
                                string newVAlue = linea.Substring(4); // Esto elimina los primeros 4 caracteres
                                string key = "TIM";
                                string value = newVAlue;
                                fragmentDictionary[key] = value;
                            }
                        }

                        this.trm = fragmentDictionary["TRM"];
                        this.mrc = fragmentDictionary["MRC"];
                        this.amount = fragmentDictionary["AMT"];
                        this.cardNumber = fragmentDictionary["CRN"];
                        this.cardType = fragmentDictionary["CRT"];
                        this.date = fragmentDictionary["DAT"];
                        this.time = fragmentDictionary["TIM"];
                        this.responseMessage = fragmentDictionary["RCP"];
                        this.authorization = fragmentDictionary["AUT"];
                        this.reference = fragmentDictionary["REF"];
                        this.sequential = fragmentDictionary["SEQ"];



                        Dictionary<string, string> transacction = new Dictionary<string, string>();

                        transacction["trm"] = this.trm;
                        transacction["mrc"] = this.mrc;
                        transacction["amount"] = this.amount;
                        transacction["cardNumber"] = this.cardNumber;
                        transacction["cardType"] = this.cardType;
                        transacction["date"] = this.date;
                        transacction["time"] = this.time;
                        transacction["responseMessage"] = this.responseMessage;
                        transacction["authorization"] = this.authorization;
                        transacction["reference"] = this.reference;
                        transacction["sequential"] = this.sequential;

                        this.TransactionsLists.Add(transacction);


                        fragmentIndex++;

                    }
                    else
                    {
                        this.error = "Índice de fragmento fuera de rango";
                    }
                }

            }
            else
            {
               
            }


        }



        public void asignarvalor(Dictionary<string, string> amount)
        {

            foreach (var kvp in amount)
            {
                MessageBox.Show("Clave: " + kvp.Key + ", Valor: " + kvp.Value);
            }
        }






    }
}
