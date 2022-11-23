Console.WriteLine("Hello, World!");
int tiempos = 1;
Console.WriteLine("Introduzca un nombre de un jugador del equipo A y luego precione ENTER hasta llenar los 5 nombres");
List<string> playersA = new List<string>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Introduzca un nombre para el equipo A");
    playersA.Add(Console.ReadLine());
}

//foreach (string player in playersA) { Console.WriteLine(player); }
List<string> playersB = new List<string>();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Introduzca un nombre para el equipo B");
    playersB.Add(Console.ReadLine());
}

List<string> annotations = new List<string>();
int puntosA = 0;
int puntosB = 0;

while (tiempos < 5)
{
    Console.WriteLine(string.Format("Actualmente el equipo A tiene {0}", puntosA));
    Console.WriteLine(string.Format("Actualmente el equipo B tiene {0}", puntosB));
    Console.WriteLine("Anote quien anoto seguido de un guion");
    Console.WriteLine(string.Format("Estamos en el tiempo {0}", tiempos));
    Console.WriteLine("Ejemplo: Juan - 3 - EquipoB");
    string annotationsA = Console.ReadLine();
    string[] destructedA = annotationsA.Split(" - ");
    annotations.Add(annotationsA);
    if (destructedA[2] == "EquipoA")
    {
        puntosA += int.Parse(destructedA[1]);
    }
    if (destructedA[2] == "EquipoB")
    {
        puntosB += int.Parse(destructedA[1]);
    }
    Console.WriteLine("Aumentar tiempo? Y/N");
    string answer = Console.ReadLine();
    if (answer == "Y" || answer == "y")
    {
        tiempos++;
    }
}

if (puntosA > puntosB)
{
    Console.WriteLine(string.Format("Gana el equipo A con {0}", puntosA));
}
if (puntosA < puntosB)
{
    Console.WriteLine(string.Format("Gana el equipo B con {0}", puntosB));
}