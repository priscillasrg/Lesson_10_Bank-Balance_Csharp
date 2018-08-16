using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo.Modelo
{
    public class Validacao : absPropriedades
    {
        public Validacao (String saldo, String deposito, String saque) : base(saldo, deposito, saque)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";

            try
            {
                this.valorSaldo = Convert.ToDouble(this.Saldo);
                this.valorDeposito = Convert.ToDouble(this.Deposito);
                this.valorSaque = Convert.ToDouble(this.Saque);             
            }
            catch (FormatException e)
            {
                this.mensagem = "Erro - digite apenas números";
            }

           if ((valorSaldo < valorSaque) && (valorDeposito < valorSaque))
            {
                this.mensagem = "Sua conta não pode ficar negativa";
            }
        }
    }
}
