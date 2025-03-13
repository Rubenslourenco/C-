using System;
using System.Globalization;

class ContaBancaria {
    public new int Numero { get; private set; }
    public new string Titular { get;  set; }
    public new double Saldo { get; private set; }


    public ContaBancaria(int numero, string titular, double saldo) {
        Numero = numero;
        Titular = titular;
    }
    public ContaBancaria(int numero, string titular, double saldo) : this (numero, titular) {
        Saldo = saldo;
    }
}