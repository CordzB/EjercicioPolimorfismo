using EjercicioPolimorfismo;

class Program
{
    static void Main(string[] args)
    {
        
        Animal[] animales = { new Perro(), new Gato(), new Pajaro() };

       
        foreach (var animal in animales)
        {
            animal.HacerSonido();
            animal.Moverse();
            Console.WriteLine();
        }
    }
}
