﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_1_KATIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // intanciação do objeto
            Veiculo golf = new Veiculo();
            Console.WriteLine("Digite a marca");
            string marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite a placa");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite o ano");
            int ano = Convert.ToInt32(Console.ReadLine());
            // objeto chamando método atribuir
            golf.atribuir(marca, modelo, placa, ano);
            Console.WriteLine(golf.retorna());
            Console.ReadKey();
        }
    }
}
