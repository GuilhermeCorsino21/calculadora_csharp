Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Divisão");
    Console.WriteLine("4 - Multiplicação");
    Console.WriteLine("5 - Fatorial");
    Console.WriteLine("6 - Sair");

    Console.WriteLine("-----------------");
    Console.WriteLine("Selecione uma opção: ");
    short res = short.Parse(Console.ReadLine());

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 5: Fatorial(); break;
        case 6: System.Environment.Exit(0); break;
        default: Menu(); break;
    }


}


static void Soma()

{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 + v2;
    Console.WriteLine($"O resultado da soma dos dois valores é: {resultado} ");
    Console.ReadKey();
    Menu();
}

static void Subtracao()

{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 - v2;
    Console.WriteLine($"O resultado da subtração dos dois valores é: {resultado} ");
    Console.ReadKey();
    Menu();
}

static void Divisao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 / v2;
    Console.WriteLine($"O resultado da subtração dos dois valores é: {resultado} ");
    Console.ReadKey();
    Menu();

}
static void Multiplicacao()
{
    Console.Clear();

    Console.WriteLine("Digite o primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = v1 * v2;
    Console.WriteLine($"O resultado da subtração dos dois valores é: {resultado} ");
    Console.ReadKey();
    Menu();

}

static void Fatorial()
{
    Console.Clear();

    float i, fatorial;
    Console.WriteLine("Digite o valor o número que será feito o fatorial: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    fatorial = v1;
    for (i = v1 - 1; i >= 1; i--)
    {
        Console.WriteLine($"{fatorial} * {i}");

        fatorial = fatorial * i;

    }

    Console.WriteLine($"O resultado do fatorial é: {fatorial} ");
    Console.ReadKey();
    Menu();
}

