using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Exercicios
{
    /* 1. Defina uma classe chamada Carro que tenha as seguintes propriedades: marca
        (string), modelo (string) e ano (int). Crie um objeto dessa classe e inicialize suas
        propriedades. */
    public class Carro
    {   
        
        public string? Marca;
        public string? Modelo;
        public int Ano;

        /* 3. Adicione um método construtor na classe Carro que receba os parâmetros para
            inicializar marca, modelo e ano. */

        public Carro(string marca, string modelo, int ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }

        /* 2. Crie um método na classe Carro chamado ExibirDetalhes, que imprime no console os
            detalhes do carro (marca, modelo e ano). */

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Ano: {Ano}");
        }
    }

    /* 4. Defina uma classe chamada Pessoa com as propriedades nome (string), idade (int) e
        cidade (string). Crie um objeto dessa classe e inicialize suas propriedades. */

    public class PessoaNova
    {
        public string? Nome;
        public int Idade;
        public string? Cidade;

       /*  5. Implemente um método na classe Pessoa chamado ExibirInformacoes, que imprime
        no console as informações da pessoa (nome, idade e cidade). */
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Cidade: {Cidade}");
        }

    }

    /* 6. Declare uma variável do tipo int chamada idade e atribua a ela o valor 25. Em seguida,
    declare uma variável do tipo string chamada nome e atribua a ela o seu nome.
    Imprima ambos os valores no console. */

    public class Variavel
    {

        public int idade = 25;
        public string? nome = "Arthur";
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }

        /* 7. Crie um método que receba dois parâmetros do tipo int e retorne a soma desses
        números. Chame esse método em Main e exiba o resultado. */

        public void Soma(int numero1, int numero2)
        {
            int somaNum = numero1 + numero2;  
            Console.WriteLine($"O Resultado da soma foi {somaNum}");
        }
        
        /* 8. Declare uma variável do tipo bool chamada estaChovendo e atribua a ela o valor false.
        Escreva uma estrutura condicional que exiba “Está chovendo” ou “Não está chovendo”
        com base no valor da variável. */

        public bool estaChovendo = false;
        public void ExibirEstaChovendo()
        {
            if (estaChovendo)
            {
                Console.WriteLine("Está chovendo");
            }
            else
            {
                Console.WriteLine("Não está chovendo");
            }
        }

        /* 9. Implemente um método chamado VerificarMaioridade que recebe uma idade como
            parâmetro e retorna true se a idade for maior ou igual a 18, e false caso contrário.
            Teste esse método no método Main.(bool resultado = objeto.VerificarIdade) */
        
        public bool VerificarMaioridade(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /* 10. Declare uma variável do tipo double chamada altura e atribua a ela o valor 1.75.
            Imprima o valor no console formatado para duas casas decimais. */

        public double altura = 1.75;
        public void ExibirAltura()
        {
            Console.WriteLine($"Altura formatada: {altura.ToString("N2")}");
        }

    }

    public class Sobrecarga
    {
        /* 11. Crie um método CalcularArea que calcule a área de um círculo recebendo o raio como
        parâmetro e retorne o resultado. Use a fórmula Área = π * raio^2. */

        public void CalcularArea(double raio)
        {
            //double area = Math.PI * Math.Pow(raio, 2);
            double area = Math.PI * raio*raio;
            Console.WriteLine($"Área do círculo: {area.ToString("N2")}");
        }

        /* 12. Sobrecarga de métodos: Crie uma sobrecarga do método CalcularArea para calcular a
        área de um retângulo, recebendo a largura e a altura como parâmetros. */

        public void CalcularArea(double largura, double altura)
        {
            
            double area = altura * largura;
            Console.WriteLine($"Área do retângulo: {area.ToString("N2")}");
        }

    }


    public class Calculadora
    {
        
    }




}