using EjercicioPolimorfismo;

class Program
{
    static void Main(string[] args)
    {

        Animal[] animales = { new Perro(), new Gato(), new Pajaro() };
        string opcion;

        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Ver sonidos de los animales");
            Console.WriteLine("2. Ver movimientos de los animales");
            Console.WriteLine("3. Salir");
            Console.Write("Ingrese el número de la opción: ");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    foreach (var animal in animales)
                    {
                        animal.HacerSonido();
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    foreach (var animal in animales)
                    {
                        animal.Moverse();
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

            if (opcion != "3")
            {
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
                Console.Clear();
            }

        } while (opcion != "3");
    }
}
