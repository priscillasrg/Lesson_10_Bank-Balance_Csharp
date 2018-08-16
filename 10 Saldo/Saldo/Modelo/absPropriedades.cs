using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo.Modelo
{
    public abstract class absPropriedades : intMetodos
    {
        public String mensagem;
        private String resposta;
        private String saldo;
        private String deposito;
        private String saque;      
        public Double valorSaldo;
        public Double valorDeposito;
        public Double valorSaque;

        protected string Resposta { get => resposta; set => resposta = value; }
        protected string Saldo { get => saldo; set => saldo = value; }
        protected string Deposito { get => deposito; set => deposito = value; }
        protected string Saque { get => saque; set => saque = value; }
    

        public absPropriedades(String saldo, String deposito, String saque)
        {
            this.Saldo = saldo;
            this.Deposito = deposito;
            this.Saque = saque;          
        }

        public absPropriedades(Double valorSaldo, Double valorDeposito, Double valorSaque)
        {
            this.valorSaldo = valorSaldo;
            this.valorDeposito = valorDeposito;
            this.valorSaque = valorSaque;
        }

        public virtual void Executar()
        {
        }

        public override string ToString()
        {
            return this.Resposta;
        }
    }
}
