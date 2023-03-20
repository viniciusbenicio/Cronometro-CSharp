

//Iniciando o Cronometro...
Menu();



static void Menu()
{
    Console.Clear();

    Console.WriteLine("S = Segundos...");
    Console.WriteLine("M = Minutos...");
    Console.WriteLine("0 = Sair...");
    Console.WriteLine("Quanto tempo deseja contar?...");

    string dados = Console.ReadLine().ToLower();
    char tipo = char.Parse(dados.Substring(dados.Length-1,1));
    int tempo = int.Parse(dados.Substring(0, dados.Length -1));
    int multiplicador = 1;

    if(tipo == 'm')
    {
        multiplicador = 60;
    }
    if(tempo == 0)
    {
        System.Environment.Exit(0); 
    }

    PreInicio(tempo * multiplicador);

    Console.WriteLine(tipo);
    Console.WriteLine(tempo);
}

static void PreInicio(int tempo)
{
    Console.Clear();

    Console.WriteLine("Pronto...");
    Thread.Sleep(1000);
    Console.WriteLine("Defina...");
    Thread.Sleep(1000);
    Console.WriteLine("Vamos....");
    Thread.Sleep(2500);

    Iniciar(tempo);
}
static void Iniciar(int tempo)
{
   
    int tempoAtual = 0;

    while (tempoAtual != tempo)
    {
        Console.Clear();
       
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine($"Cronometro finalizado....");
    Thread.Sleep(1000);
    Menu();
}