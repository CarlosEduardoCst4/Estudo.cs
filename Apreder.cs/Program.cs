//1
string nome = "Carlos";
int idade = 20; //float idade = 20.0f ou decimal idade = 20.0m

Console.WriteLine($"Nome {nome} idade {idade}");

//2 - Variavel dinamica(tipo boolean, string, int, float, decimal, char, etc)

var variavel = false;

Console.WriteLine($"Variavel: {variavel}");

//3 contatenação

string Nome = "Carlos";
int Idade = 20;

Console.WriteLine("Meu nome é " + Nome + " e tenho " + Idade + " anos ");

//4 Operadores aritméticos +, -, *, /, %

int numero1 = 10;
int numero2 = 20;

Console.WriteLine(numero1 + numero2);

//5 Operadores de comparação ==, !=, >, <, >=, <=

int numero3 = 10;
int numero4 = 10;

if(numero3 == numero4)
    Console.WriteLine(numero3 + numero4);

//6 Operadores lógicos &&, ||, ! / Operadores de negação

bool valor1 = true;
bool valor2 = true;

if (valor1 && valor2)
    Console.WriteLine("Verdadeiro");

//------------------------------------------------------------//

bool valor3 = false;

if(!valor3)
{
    Console.WriteLine("Operador de negação");
}

//7 Função e Metodos

void Saudacao(string nome1)
{
    Console.WriteLine(nome1);
}
Saudacao("Carlos");

//------------------------------------------------------------//

int idade1 = 20;

if(idade1 >= 18)
{
    Console.WriteLine("Maior de idade");
} else
    {
        Console.WriteLine("Menor de idade");
    }

//------------------------------------------------------------//

string cor = "Vermelho";

switch(cor)
    {
    case "azul":
            Console.WriteLine("Cor azul");
        break;
    case "Vermelho":
            Console.WriteLine("Cor vermelho");
        break;
    default:
            Console.WriteLine("Outra cor");
        break;
    }

//8 Laços de repetição

for (int i=0; i < 5; i++)
{
    Console.WriteLine($"Numero: {i}");
}

//------------------------------------------------------------//

int j = 0;

while (j < 5)
{
    Console.WriteLine(j);
    j++;
}

//------------------------------------------------------------//

int j = 0;

do
{
Console.WriteLine($"num: {j}");
    j++;
} while (j < 5);

//9 Arrays e ForEach

string[] frutas = { "Maça", "Banana", "Laranja" };

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

//------------------------------------------------------------//


string[] fruta = { "Maça", "Banana", "Laranja" };
{
    Console.WriteLine(fruta[2]);
}
//------------------------------------------------------------//
namespace tabela
{
    class Pessoa
    {
        public string NOME;
        public int IDADE;

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NOME} Idade: {IDADE}");
        }
    }
}

using tabela;

Pessoa p = new Pessoa();
p.Nome = "Carlos";
p.Idade = 20;
p.Apresentar();

//------------------------------------------------------------//

int[] intArray = new int[] {1,2,3,4,5,6,7,8,9,10 };

List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
intList.Remove(1);
intList.add(11);
int currentNumber = intArray[i];
