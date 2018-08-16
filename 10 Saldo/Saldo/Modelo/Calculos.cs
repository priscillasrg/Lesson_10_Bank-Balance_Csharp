using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo.Modelo
{
    public class Calculos: absPropriedades
    {
        public Calculos(Double valorSaldo, Double valorDeposito, Double valorSaque): base (valorSaldo, valorDeposito, valorSaque)
        {
            Executar();
        }

        public override void Executar()
        {
            this.valorSaldo = valorSaldo + valorDeposito - valorSaque;
            this.Resposta = "Seu saldo final é de: \n" + valorSaldo.ToString("#0.00");
                
        }
    }
}
