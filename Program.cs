

//Iniciando o Cronometro...
Menu();



static void Menu()
{
    Console.Clear();

    Console.WriteLine("S = Segundos...");
    Console.WriteLine("M = Minutos...");
    Console.WriteLine("0 = Sair...");
    Console.WriteLine("Quanto tempo deseja contar?...");
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
}