using System;
using System.Drawing;
using System.Windows.Forms;

namespace Transactions_DC
{
    public partial class transactions: Form, ITransation
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
        public string hostname { get; set; }

        public transactions()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;



        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void transactions_Load(object sender, EventArgs e)
        {

        }

        private void TR_TABLE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void asignValue()
        {

            TR_TABLE.Rows.Add(this.trm, this.cardNumber, this.date, this.time, this.cardType, this.amount, this.responseMessage, this. authorization, this.reference, this.mrc, this.sequential);


        }






        public void showMessage( string pos)
        {

            DateTime hoy = DateTime.Now;

            if (this.error == "error path")
            {
                this.message_lbl.ForeColor = Color.FromArgb(10, 159, 238);

                this.message_lbl.Text = $"No se encontraron Trasacciones en esta caja [{pos}] para este día {hoy}".ToUpper();

            }
            else if (this.error == "error conn")
            {
                this.message_lbl.ForeColor = Color.Red;

                this.message_lbl.Text = $"No se puede conectar a esta caja {pos}".ToUpper();
            }
            else
            {
                this.message_lbl.ForeColor = Color.Green;
                this.message_lbl.Text = $"Rsvisando transacciones para: {pos}".ToUpper();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TR_TABLE.Rows.Clear();

            this.hostname = host_TXT.Text;

            this.message_lbl.Text = this.error;



            Transaction tr = new Transaction();

            tr.convertData(this.hostname);

            this.error = tr.error;

            this.showMessage(this.hostname);

            foreach (var diccionario in tr.TransactionsLists)
            {
                this.trm = diccionario["trm"];
                this.cardNumber = diccionario["cardNumber"];
                this.date = diccionario["date"];
                this.time = diccionario["time"];
                this.cardType = diccionario["cardType"];
                this.amount = diccionario["amount"];
                this.responseMessage = diccionario["responseMessage"];
                this.authorization = diccionario["authorization"];
                this.reference = diccionario["reference"];
                this.mrc = diccionario["mrc"];
                this.sequential = diccionario["sequential"];




                this.asignValue();
            }
        }


     


        
    }
}
