Console.Write("Ingrese el primer numero");
var numeroUno=int.Parse(Console.ReadLine());
Console.Write("Ingrese el segundo numero");
var numeroDos=int.Parse(Console.ReadLine());
if (numeroUno==numeroDos)
{
    Console.WriteLine("Ambos son iguales");

}
else if (numeroUno > numeroDos)
{
    Console.WriteLine($"{numeroUno} es mayor a {numeroDos}");
}
else
{
    Console.WriteLine($"{numeroDos} es mayor a {numeroUno}");
}