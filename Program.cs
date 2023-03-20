

//Iniciando o Cronometro...
Iniciar();




static void Iniciar()
{
    int tempo = 10;
    int tempoAtual = 0;

    while (tempoAtual != tempo)
    {
        Console.Clear();
       
        tempoAtual++;
        Console.WriteLine(tempoAtual);
        Thread.Sleep(1000);
    }
}