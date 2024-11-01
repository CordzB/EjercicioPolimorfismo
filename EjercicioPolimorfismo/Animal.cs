

namespace EjercicioPolimorfismo
{
    public class Animal
    {
        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido.");
        }

        public virtual void Moverse()
        {
            Console.WriteLine("El animal se mueve de alguna forma.");
        }


    }
}
