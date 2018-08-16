namespace Saldo
{
    partial class frmPrincipal
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
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblSaque = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.txbSaque = new System.Windows.Forms.TextBox();
            this.txbDeposito = new System.Windows.Forms.TextBox();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPriscillaRizzardo = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(12, 28);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(71, 13);
            this.lblSaldo.TabIndex = 0;
            this.lblSaldo.Text = "Digite o saldo";
            // 
            // lblSaque
            // 
            this.lblSaque.AutoSize = true;
            this.lblSaque.Location = new System.Drawing.Point(12, 76);
            this.lblSaque.Name = "lblSaque";
            this.lblSaque.Size = new System.Drawing.Size(116, 13);
            this.lblSaque.TabIndex = 1;
            this.lblSaque.Text = "Digite o valor do saque";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Location = new System.Drawing.Point(12, 53);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(127, 13);
            this.lblDeposito.TabIndex = 2;
            this.lblDeposito.Text = "Digite o valor do depósito";
            // 
            // txbSaldo
            // 
            this.txbSaldo.Location = new System.Drawing.Point(145, 21);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(123, 20);
            this.txbSaldo.TabIndex = 3;
            // 
            // txbSaque
            // 
            this.txbSaque.Location = new System.Drawing.Point(145, 76);
            this.txbSaque.Name = "txbSaque";
            this.txbSaque.Size = new System.Drawing.Size(123, 20);
            this.txbSaque.TabIndex = 5;
            // 
            // txbDeposito
            // 
            this.txbDeposito.Location = new System.Drawing.Point(145, 50);
            this.txbDeposito.Name = "txbDeposito";
            this.txbDeposito.Size = new System.Drawing.Size(123, 20);
            this.txbDeposito.TabIndex = 4;
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.BackColor = System.Drawing.Color.White;
            this.lblResposta.Location = new System.Drawing.Point(53, 190);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(52, 13);
            this.lblResposta.TabIndex = 6;
            this.lblResposta.Text = "Resposta";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(115, 122);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(109, 26);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPriscillaRizzardo
            // 
            this.lblPriscillaRizzardo.AutoSize = true;
            this.lblPriscillaRizzardo.Location = new System.Drawing.Point(183, 316);
            this.lblPriscillaRizzardo.Name = "lblPriscillaRizzardo";
            this.lblPriscillaRizzardo.Size = new System.Drawing.Size(130, 13);
            this.lblPriscillaRizzardo.TabIndex = 8;
            this.lblPriscillaRizzardo.Text = "Made by Priscilla Rizzardo";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Location = new System.Drawing.Point(44, 178);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(247, 97);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(337, 349);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblPriscillaRizzardo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbDeposito);
            this.Controls.Add(this.txbSaque);
            this.Controls.Add(this.txbSaldo);
            this.Controls.Add(this.lblDeposito);
            this.Controls.Add(this.lblSaque);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.listView1);
            this.Name = "frmPrincipal";
            this.Text = "Saldo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblSaque;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.TextBox txbSaque;
        private System.Windows.Forms.TextBox txbDeposito;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblPriscillaRizzardo;
        private System.Windows.Forms.ListView listView1;
    }
}

