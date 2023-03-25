using static System.Runtime.InteropServices.JavaScript.JSType;
using String = System.String;

void adivina()
{
    const int oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte intentos, banderaControl;
    string linea;

    Random random = new Random();
    numeroCPU = Convert.ToInt32(random.Next(1,20));

    intentos = 1;
    banderaControl = 0;

    Console.WriteLine("Hola, estoy pensando en un número del 1 al 20. ¡Te doy 4 oportunidades para adivinar cuál es!");

    do
    {
        numeroUsuario = Convert.ToInt32(Console.ReadLine());

        if (numeroUsuario == numeroCPU)
        {
            Console.WriteLine("¡Acertaste!");
            banderaControl = 1;
        } else
        {
            if (numeroUsuario > numeroCPU)
            {
                Console.WriteLine("El número en el que pensé es menor al que ingresaste.");
            }
            else
            {
                Console.WriteLine("El número en el que pensé es mayor al que ingresaste.");
            }
        }

        intentos++;

    } while (((intentos <= oportunidades) & (banderaControl == 0)));

    if (banderaControl == 0)
    {
        Console.WriteLine($"El número que pensé era: " +numeroCPU);
    }
}

void buscaMayor()
{
    int mayor = 0, numero = 0, menor = 100;
    Random rand = new Random();

    for(int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        Console.WriteLine(numero);

        if (numero > mayor)
        {
            mayor = numero;
        }

        if (numero < menor)
        {
            menor = numero;
        }
    }

    Console.WriteLine("\nEl número mayor es: " + mayor);
    Console.WriteLine("\nEl número menor es: " + menor);

}

void arreglos()
{
    int[] notas = new int[10];
    int mayor = 0, menor = 100, promedio = 0, sumatoria = 0;
    Random rnd = new Random();

    for(int i = 0; i < notas.Length; i++)
    {
        notas[i] = rnd.Next(100);

        if (notas[i] > mayor)
        {
            mayor = notas[i];
        }

        if (notas[i] < menor)
        {
            menor = notas[i];
        }

        sumatoria += notas[i];
        promedio = sumatoria / notas.Length;

    }

    Console.WriteLine("Desplegando información: ");

    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }

    Console.WriteLine("\nEl número mayor es: " + mayor);
    Console.WriteLine("El número menor es: " + menor);
    Console.WriteLine("Promedio: " + promedio);

}

void nombres()
{
    int ganadorPierna, ganadorCerdo, ganadores = 2;
    Random rnd = new Random();
    String[] nombre = new String[6];
    nombre[0] = "Jairo";
    nombre[1] = "Brandom";
    nombre[2] = "Hector";
    nombre[3] = "Yeimi";
    nombre[4] = "Fatima";
    nombre[5] = "Carlos";

    for(int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i+": " + nombre[i]);
    }

    do
    {
        ganadorPierna = rnd.Next(0, 5);
        ganadorCerdo = rnd.Next(0, 5);
    } while (ganadorPierna == ganadorCerdo);

    Console.WriteLine("\n¡El segundo ganador se lleva la pierna de cerdo! Felicidades " + nombre[ganadorPierna]);
    Console.WriteLine("¡El primer ganador se lleva el cerdo sin pierna! Felicidades " + nombre[ganadorCerdo]);
}

nombres();
//arreglos();
//buscaMayor();
//adivina();