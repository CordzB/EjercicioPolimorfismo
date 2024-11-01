

namespace EjercicioPolimorfismo
{
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El gato maúlla.");
        }

        public override void Moverse()
        {
            Console.WriteLine("El gato salta.");
        }

    }
}
