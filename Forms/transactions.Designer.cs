namespace Transactions_DC
{
    partial class transactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TR_TABLE = new System.Windows.Forms.DataGridView();
            this.trm_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.card_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardType_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.response_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorization_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reference_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrc_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sequential_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message_lbl = new System.Windows.Forms.Label();
            this.host_TXT = new System.Windows.Forms.TextBox();
            this.check_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TR_TABLE)).BeginInit();
            this.SuspendLayout();
            // 
            // TR_TABLE
            // 
            this.TR_TABLE.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.TR_TABLE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TR_TABLE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trm_column,
            this.card_column,
            this.date_column,
            this.time_column,
            this.cardType_column,
            this.amount_column,
            this.response_column,
            this.authorization_column,
            this.reference_column,
            this.mrc_column,
            this.sequential_column});
            this.TR_TABLE.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TR_TABLE.Location = new System.Drawing.Point(0, 150);
            this.TR_TABLE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TR_TABLE.Name = "TR_TABLE";
            this.TR_TABLE.RowHeadersVisible = false;
            this.TR_TABLE.RowHeadersWidth = 50;
            this.TR_TABLE.RowTemplate.Height = 24;
            this.TR_TABLE.Size = new System.Drawing.Size(1100, 500);
            this.TR_TABLE.TabIndex = 1;
            this.TR_TABLE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TR_TABLE_CellContentClick);
            // 
            // trm_column
            // 
            this.trm_column.HeaderText = "TRM";
            this.trm_column.MinimumWidth = 6;
            this.trm_column.Name = "trm_column";
            this.trm_column.Width = 125;
            // 
            // card_column
            // 
            this.card_column.HeaderText = "CARD";
            this.card_column.MinimumWidth = 6;
            this.card_column.Name = "card_column";
            this.card_column.Width = 125;
            // 
            // date_column
            // 
            this.date_column.HeaderText = "DATE";
            this.date_column.MinimumWidth = 6;
            this.date_column.Name = "date_column";
            this.date_column.Width = 125;
            // 
            // time_column
            // 
            this.time_column.HeaderText = "TIME";
            this.time_column.MinimumWidth = 6;
            this.time_column.Name = "time_column";
            this.time_column.Width = 125;
            // 
            // cardType_column
            // 
            this.cardType_column.HeaderText = "CARD TYPE";
            this.cardType_column.MinimumWidth = 6;
            this.cardType_column.Name = "cardType_column";
            this.cardType_column.Width = 125;
            // 
            // amount_column
            // 
            this.amount_column.HeaderText = "AMOUNT";
            this.amount_column.MinimumWidth = 6;
            this.amount_column.Name = "amount_column";
            this.amount_column.Width = 125;
            // 
            // response_column
            // 
            this.response_column.HeaderText = "RESPONSE";
            this.response_column.MinimumWidth = 6;
            this.response_column.Name = "response_column";
            this.response_column.Width = 125;
            // 
            // authorization_column
            // 
            this.authorization_column.HeaderText = "AUTHORIZATION";
            this.authorization_column.MinimumWidth = 6;
            this.authorization_column.Name = "authorization_column";
            this.authorization_column.Width = 125;
            // 
            // reference_column
            // 
            this.reference_column.HeaderText = "REFERENCE";
            this.reference_column.MinimumWidth = 6;
            this.reference_column.Name = "reference_column";
            this.reference_column.Width = 125;
            // 
            // mrc_column
            // 
            this.mrc_column.HeaderText = "MRC";
            this.mrc_column.MinimumWidth = 6;
            this.mrc_column.Name = "mrc_column";
            this.mrc_column.Width = 125;
            // 
            // sequential_column
            // 
            this.sequential_column.HeaderText = "SEQUENTIAL";
            this.sequential_column.MinimumWidth = 6;
            this.sequential_column.Name = "sequential_column";
            this.sequential_column.Width = 125;
            // 
            // message_lbl
            // 
            this.message_lbl.AutoSize = true;
            this.message_lbl.Font = new System.Drawing.Font("JetBrains Mono", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_lbl.ForeColor = System.Drawing.Color.Green;
            this.message_lbl.Location = new System.Drawing.Point(81, 105);
            this.message_lbl.Name = "message_lbl";
            this.message_lbl.Size = new System.Drawing.Size(0, 26);
            this.message_lbl.TabIndex = 2;
            // 
            // host_TXT
            // 
            this.host_TXT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.host_TXT.Cursor = System.Windows.Forms.Cursors.Default;
            this.host_TXT.Font = new System.Drawing.Font("JetBrains Mono", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.host_TXT.Location = new System.Drawing.Point(112, 21);
            this.host_TXT.MaxLength = 15;
            this.host_TXT.Name = "host_TXT";
            this.host_TXT.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.host_TXT.Size = new System.Drawing.Size(209, 38);
            this.host_TXT.TabIndex = 3;
            this.host_TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // check_BTN
            // 
            this.check_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.check_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.check_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.check_BTN.Location = new System.Drawing.Point(425, 18);
            this.check_BTN.Name = "check_BTN";
            this.check_BTN.Size = new System.Drawing.Size(217, 47);
            this.check_BTN.TabIndex = 6;
            this.check_BTN.Text = "CONSULTAR TRANSACCIONES";
            this.check_BTN.UseVisualStyleBackColor = true;
            this.check_BTN.Click += new System.EventHandler(this.button3_Click);
            // 
            // transactions
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1667, 835);
            this.Controls.Add(this.check_BTN);
            this.Controls.Add(this.host_TXT);
            this.Controls.Add(this.message_lbl);
            this.Controls.Add(this.TR_TABLE);
            this.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VERIFICAR TRANSACCIONES CON TARJETA";
            this.Load += new System.EventHandler(this.transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TR_TABLE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TR_TABLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn trm_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn card_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardType_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn response_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorization_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn reference_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrc_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sequential_column;
        private System.Windows.Forms.Label message_lbl;
        private System.Windows.Forms.TextBox host_TXT;
        private System.Windows.Forms.Button check_BTN;
    }
}

