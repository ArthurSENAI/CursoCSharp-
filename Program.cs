using CursoCSharp;
using CursoCSharp.Exercicios;

//ArrayExemplos.DemonstrarArray();
//ListaExemplo.DemonstrarLista();

/* Aluno arthur = new Aluno();
arthur.nome = "Arthur S. Araujo";
arthur.matricula = "RA 020506";
arthur.curso = "Tecnico";

Aluno suelen = new Aluno();
suelen.nome = "Suelen A. de Miranda";
suelen.matricula = "RA 020507";
suelen.curso = "Tecnico";
Console.WriteLine($"Nome: {suelen.nome}, Matricula: {suelen.matricula}, Curso: {suelen.curso}");
Console.WriteLine($"Nome: {arthur.nome}, Matricula: {arthur.matricula}, Curso: {arthur.curso}"); */

/*  EscopoVariaveis escopo = new EscopoVariaveis();
escopo.Metodo1();
escopo.Metodo2();
escopo.Metodo3();
escopo.ExibirContadorGlobal(); */

/* TratamentoExcecoes tr = new TratamentoExcecoes();
tr.ExecutarDivisao(9,3);
TratamentoExcecoes tr1 = new TratamentoExcecoes();
tr1.ExecutarDivisao(10,0);
tr1.ExecutarDivisao(0,2); */

//ArrayExercicio.Exercicio1();
//ArrayExercicio.Exercicio2();
//ArrayExercicio.Exercicio3();
//ArrayExercicio.Exercicio4();
//ArrayExercicio.Exercicio5();

//ListExercicio.Exercicio1();
//ListExercicio.Exercicio2();
//ListExercicio.Exercicio3();
//ListExercicio.Exercicio4();


//EscopoVariaveisExercicio exercicioArthur = new EscopoVariaveisExercicio();
//exercicioArthur.CalculaSoma(2,4);
//exercicioArthur.XCondicional(2);
//exercicioArthur.CapturarExcecao("a");
//exercicioArthur.NumeroPositivo(2);

/* EscopoVariaveisExercicio.Carro carro = new EscopoVariaveisExercicio.Carro();
carro.marca = "Toyota";
carro.Escrever(); // Exercicio 2
carro.ConflitoEscopo(); // Exercicio 3  */

/* EscopoVariaveisExercicio.Contador contador = new EscopoVariaveisExercicio.Contador();
contador.IncrementarPor10(5); */


/* ParadigmasPOO conceitos = new ParadigmasPOO();

// Explicar Orientação a Objetos
conceitos.ExplicarOrientacaoAObjetos();

// Explicar a diferença entre Programação Estruturada e Orientada a Objetos
conceitos.DiferencaEntreParadigmas();

// Explicar os Pilares da Orientação a Objetos
conceitos.ExplicarPilares(); */

/* // 1. Criando Objetos (Instanciando a classe Pessoa)
Pessoa pessoa1 = new Pessoa("Alice", 30);
Pessoa pessoa2 = new Pessoa("Bob", 25);

// 2. Usando Métodos de Instância (Métodos não estáticos)
pessoa1.ExibirInformacoes();
pessoa2.ExibirInformacoes();

// 3. Usando Método Estático (Pertence à Classe, não à instância)
Pessoa.ExibirNumeroDePessoas();

// 4. Membros de Instância vs. Membros Estáticos
Console.WriteLine($"Pessoa1: {pessoa1.Nome}, Idade: {pessoa1.Idade}");
Console.WriteLine($"Pessoa2: {pessoa2.Nome}, Idade: {pessoa2.Idade}");
Console.WriteLine($"Número total de pessoas: {Pessoa.NumeroDePessoas}");
 */

// Instanciando a classe Produto usando o construtor padrão
Produto produto1 = new Produto();
produto1.ExibirInformacoes();

// Instanciando a classe Produto usando o construtor com parâmetros
Produto produto2 = new Produto("Smartphone", 1999.99m, 50);
produto2.ExibirInformacoes();

// Modificando atributos usando propriedades
produto1.Nome = "Notebook";
produto1.Preco = 2999.99m;
produto1.Estoque = 25;
produto1.ExibirInformacoes();

// Acessando método protegido através da classe derivada
ProdutoEspecial produtoEspecial = new ProdutoEspecial();
produtoEspecial.ExibirMetodoProtegido();











