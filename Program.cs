//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());

        int somaAB = a + b;

        if (somaAB < c)
        {
            Console.WriteLine("A soma de A + B é menor que C.");
        }
        else
        {
            Console.WriteLine("A soma de A + B não é menor que C.");
        }
    }
} //


//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite o sexo (M/F): ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); 

        Console.Write("Digite o estado civil (SOLTEIRA/SOLTEIRO/CASADA/CASADO): ");
        string estadoCivil = Console.ReadLine().ToUpper();

        if (sexo == 'F' && estadoCivil == "CASADA")
        {
            Console.Write("Digite o tempo de casada (anos): ");
            int tempoCasada = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nInformações:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Estado Civil: {estadoCivil}");
            Console.WriteLine($"Tempo de Casada: {tempoCasada} anos");
        }
        else
        {
            Console.WriteLine("\nInformações:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Estado Civil: {estadoCivil}");
        }
    }
}//


//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine($"O número {numero} é par.");
        }
        else
        {
            Console.WriteLine($"O número {numero} é ímpar.");
        }
    }
}//


//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int B = int.Parse(Console.ReadLine());

        int C;

        if (A == B)
        {
            C = A + B;
        }
        else
        {
            C = A * B;
        }

        Console.WriteLine("O resultado é: " + C);
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        int resultado;

        if (numero > 0)
        {
            // Se o número for positivo, encontre o dobro
            resultado = numero * 2;
        }
        else
        {
            // Se o número for negativo, encontre o triplo
            resultado = numero * 3;
        }

        Console.WriteLine("O resultado é: " + resultado);

        // Aguarde o usuário pressionar Enter antes de fechar o console
        Console.ReadLine();
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Insira o primeiro valor booleano (True/False): ");
        bool valor1 = Convert.ToBoolean(Console.ReadLine());

        Console.Write("Insira o segundo valor booleano (True/False): ");
        bool valor2 = Convert.ToBoolean(Console.ReadLine());

        if (valor1 && valor2)
        {
            Console.WriteLine("Ambos os valores são VERDADEIROS.");
        }
        else
        {
            Console.WriteLine("Pelo menos um dos valores é FALSO.");
        }
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            numero += 5;
        }
        else
        {
            numero += 8;
        }

        Console.WriteLine("O resultado da operação é: " + numero);

        Console.ReadLine();
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro valor inteiro: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo valor inteiro: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro valor inteiro: ");
        int valor3 = int.Parse(Console.ReadLine());

        if (valor1 == valor2 || valor1 == valor3 || valor2 == valor3)
        {
            Console.WriteLine("Por favor, digite valores diferentes.");
            return;
        }

        int temp;
        if (valor1 < valor2)
        {
            temp = valor1;
            valor1 = valor2;
            valor2 = temp;
        }

        if (valor1 < valor3)
        {
            temp = valor1;
            valor1 = valor3;
            valor3 = temp;
        }

        if (valor2 < valor3)
        {
            temp = valor2;
            valor2 = valor3;
            valor3 = temp;
        }

        Console.WriteLine("Valores em ordem decrescente: {0}, {1}, {2}", valor1, valor2, valor3);
    }
}//

using System;

//class Program
{
    static void Main()
    {
        Console.WriteLine("Digite a altura em metros:");
        double altura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o sexo (M para masculino, F para feminino):");
        char sexo = char.Parse(Console.ReadLine().ToUpper());

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58;
            Console.WriteLine($"O peso ideal para um homem com {altura} metros de altura é: {pesoIdeal} kg");
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
            Console.WriteLine($"O peso ideal para uma mulher com {altura} metros de altura é: {pesoIdeal} kg");
        }
        else
        {
            Console.WriteLine("Sexo inválido. Por favor, insira M para masculino ou F para feminino.");
        }
    }
}//

//using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso em quilogramas: ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = CalcularIMC(peso, altura);

        string condicao = DeterminarCondicaoPeso(imc);

        Console.WriteLine($"O seu IMC é {imc:F2}, e a condição de peso é: {condicao}");
    }

    static double CalcularIMC(double peso, double altura)
    {
        return peso / Math.Pow(altura, 2);
    }

    static string DeterminarCondicaoPeso(double imc)
    {
        if (imc < 18.5)
        {
            return "Abaixo do peso";
        }
        else if (imc >= 18.5 && imc < 25)
        {
            return "Peso normal";
        }
        else if (imc >= 25 && imc < 30)
        {
            return "Acima do peso";
        }
        else
        {
            return "Obeso";
        }
    }
}
//
