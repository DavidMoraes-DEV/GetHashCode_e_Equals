using GetHashCode_e_Equals.Entities;
using System;

namespace GetHashCode_e_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * GetHashCode e Equals
            - São operações da classe Object utilizadas para comparar se um objeto é igual a outro

            - Equals: É lento, porém tem resposta 100%
            - GetHashCode: É rápido, porém resposta positiva não é 100%

            - Os tipos pré-definidos já possuem implementação para essas operações. Classes e structs personalizados precisam sobrepô-las.

            * EQUALS
            - É um método que compara se o objeto é igual a outro, retornando true ou false.
            Exemplo:*/
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine("Equals: " + a.Equals(b));
            Console.WriteLine();

            /*
             * GetHashCode:
             - É um método que retorna um número inteiro representando um código gerado a partir das informações do objeto
            Exemplo:*/

            string c = "Maria";
            string d = "Alex";

            Console.WriteLine("GetHashCode():");
            Console.WriteLine(c.GetHashCode());
            Console.WriteLine(d.GetHashCode());

            /*
            * REGRA DE OURO DO GetHashCode:
            - Se o código de dois objetos for diferente, então os dois objetos são diferentes
            - Se o código de dois objetos for igual, MUITO PROVAVELMENTE os objetos são iguais(pode haver colisão)
            */

            Console.WriteLine("Utilizando o Equals e HashCode:");
            Client e = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client f = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine();
            Console.WriteLine("O email de Maria é igual ao de Alex: " + e.Equals(f));
            Console.WriteLine();
            Console.WriteLine("Hash Code de Maria: " + e.GetHashCode());
            Console.WriteLine("Hash Code de Alex: " + f.GetHashCode());
        }
    }
}
