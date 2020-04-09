using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ObservadorConcreto : Observador
    {
        private string _nome;
        private string _estadoobservador;
        private AssuntoConcreto _assunto;

        public ObservadorConcreto(AssuntoConcreto assuntoConcreto, string nome)
        {
            _assunto = assuntoConcreto;
            _nome = nome;
        }
        public override void Update()
        {
            _estadoobservador = _assunto.EstadoAssunto;
            Console.WriteLine($"Observador {_nome} seu novo estado é: {_estadoobservador}");
        }

        public AssuntoConcreto Assunto { get; set; }
    }
}
