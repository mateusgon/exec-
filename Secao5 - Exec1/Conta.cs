using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Secao5___Exec1
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public Conta(int NumConta, string Titular)
        {
            this.NumConta = NumConta;
            this.Titular = Titular;
        }

        public Conta(int NumConta, string Titular, double Saldo) : this(NumConta, Titular)
        {
            this.Saldo = Saldo;
        }

        public void Sacar(double Valor)
        {
            this.Saldo = this.Saldo - Valor;
        }

        public void Depositar(double Valor)
        {
            this.Saldo = this.Saldo + Valor;
        }
        
        public override string ToString()
        {
            return "Conta: " + NumConta + ", Titular: " + Titular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
