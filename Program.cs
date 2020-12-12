using System;
using POO_PolimosrfismoSobrecarga.classes;

namespace POO_PolimosrfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar("vitor");
            fun.Mostrar(2);

            Console.Beep();
        }
    }
}
