namespace POO_exercicos_02
{
    public class Contacorrente : Contabancaria
    {
        private const double _Taxafixa = 5.00;

       public override void Sacar (int numeroconta, double saldoinicial, string titular) 
            : base (numeroconta, saldoinicial, titular) { }
    }
}
