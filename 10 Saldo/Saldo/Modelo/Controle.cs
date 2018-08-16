using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo.Modelo
{
    public class Controle : absPropriedades
    {
        public Controle(String saldo, String deposito, String saque) : base(saldo, deposito, saque)
        {
            Executar();
        }

        public override void Executar()
        {
            this.mensagem = "";
            absPropriedades validacao = new Validacao(this.Saldo, this.Deposito, this.Saque);

            if (validacao.mensagem.Equals(""))
            {
                absPropriedades calculos = new Calculos(validacao.valorSaldo, validacao.valorDeposito, validacao.valorSaque);
                this.Resposta = calculos.ToString();
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
