using System;

namespace POO_PolimosrfismoSobrecarga.classes
{
    public class Funcionario
    {
        // sintaxe completa de propFull

        // private int myVar;
        // public int MyProperty
        // {
        //     get { return myVar; }
        //     set { myVar = value; }
        // }
        
        //alternativo
        //sintaxe redusida de prop
        // public string Name { get; set; }
        
        //atividade
       public string[] lista = {"vitor", "manoel","winicius"};
        public void Mostrar()
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice)
        {
            Console.WriteLine($"busca por indice {lista [indice]}");
        }

        public void Mostrar(string buscar)
        {
            foreach (var item in lista)
            {
                if(item == buscar){
                Console.WriteLine($"Resultado da busca {item}");
                }
            }
        }
        
    }
}