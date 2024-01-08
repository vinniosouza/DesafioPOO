
using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main()
    {
        iPhone meuIphone = new iPhone("9999999", "iphone13", "imei", 25);
        meuIphone.InstalarAplicativo("Gloryfy");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
       

        Nokia meuNokia = new Nokia("9999999", "iphone13", "imei", 25);
        meuNokia.InstalarAplicativo("BíbliaSagrada");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
    }
}

