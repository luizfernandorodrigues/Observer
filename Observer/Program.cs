using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            AssuntoConcreto s = new AssuntoConcreto();
            s.Anexar(new ObservadorConcreto(s, "X"));
            s.Anexar(new ObservadorConcreto(s, "Y"));
            s.Anexar(new ObservadorConcreto(s, "Z"));

            s.EstadoAssunto = "ABC";
            s.Notificar();

            Console.ReadKey();
        }
    }
}
