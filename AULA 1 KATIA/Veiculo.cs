using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA_1_KATIA
{
    public class Veiculo
    {
        // declaração de atributos
        string marca;
        string modelo;
        string placa;
        int ano;
        // método para atribuir valores
        public void atribuir(string ma, string mo, string pl, int a)
        {
            this.ano = a;
            this.marca = ma;
            this.modelo = mo;
            this.placa = pl;
        }
        // método para retornar valores
        public string retorna()
        {
            return "Marca = " + this.marca + "\nModelo = " + this.modelo + "\nPlaca = " + this.placa + 
                "\nAno de fabricaçã o= " + this.ano;
        }
    }
}
