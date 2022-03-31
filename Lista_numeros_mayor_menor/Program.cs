Console.WriteLine("Introduzca los numeros que quiera. Cunado quiera finalizar, introduzca PARAR ");
string cadenaintroducida = "";
List<int> numeros = new List<int>();

while (cadenaintroducida != "PARAR")
{
    cadenaintroducida = Console.ReadLine();
    if (cadenaintroducida != "PARAR")
    {
        int numero = Convert.ToInt32(cadenaintroducida);
        numeros.Add(numero);
    }
}

List<int> numerosOrdenados = new List<int>();

while (numeros.Count > 0)
{
    int numMenor = Int32.MaxValue;
    foreach (int numero in numeros)
    {
        if (numero <= numMenor)
        {
            numMenor = numero;
        }
    }

    numerosOrdenados.Add(numMenor);
    numeros.Remove(numMenor);
}

foreach (int numero in numerosOrdenados)
{
    Console.Write(numero + ",");
}
Console.ReadKey(true);