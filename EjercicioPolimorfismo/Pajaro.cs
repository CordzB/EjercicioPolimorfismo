

namespace EjercicioPolimorfismo
{
    public class Pajaro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El pájaro canta.");
        }

        public override void Moverse()
        {
            Console.WriteLine("El pájaro vuela.");
        }

    }
}
