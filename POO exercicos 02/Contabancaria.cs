using System.ComponentModel.Design;

namespace POO_exercicos_02
{
    public class Contabancaria
    {
        private string _numeroconta;
        private string _Titular;
        private double _saldo;

        public Contabancaria (string numeroconta, double saldo, string titular)
        {
            this._numeroconta = numeroconta;
            this._saldo = saldo;
            this._Titular = titular;
        }

        public string numeroconta
        {
            get
            {
                return numeroconta;
            }
            set
            {
                if (numeroconta.Length < 11)
                {
                    Console.WriteLine("O número da conta deve conter 11 digitos.");
                }
            }
        }

        public string titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public double saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public void Deposito (double valor)
        {
            if (valor > 0)
            {
                saldo += valor;
                Console.WriteLine($"Depósito de {valor} finalizado!");
            }
            else
            {
                Console.WriteLine("Depósito invalido");
            }
        }

        public virtual void Saque (double saque)
        {
            if (saque > 0 )
            {
                Console.WriteLine("Saque finalizado!");
            }
            if (saque > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public void Exibirsaldo ()
        {
            Console.WriteLine($"");
        }

    }
}
