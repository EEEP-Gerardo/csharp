using System;

class Program
{
    static void Main()
    {
        // Defina a distância em metros (por exemplo, a distância da Terra à Lua é de aproximadamente 384,400,000 metros)
        double distancia = 384400000;

        // Defina o tempo em segundos (por exemplo, o tempo que a luz leva para percorrer essa distância)
        double tempo = 1.2802; // Este valor representa aproximadamente 1.2802 segundos

        // Calcule a velocidade da luz
        double velocidadeDaLuz = distancia / tempo;

        // Exiba o resultado
        Console.WriteLine("A velocidade da luz é de aproximadamente " + velocidadeDaLuz + " metros por segundo.");
    }
}
