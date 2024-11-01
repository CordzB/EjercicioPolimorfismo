

namespace EjercicioPolimorfismo
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra.");
        }

        public override void Moverse()
        {
            Console.WriteLine("El perro corre.");
        }

    }
}
