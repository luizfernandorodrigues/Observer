﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Assunto
    {
        private List<Observador> observadores = new List<Observador>();

        public void Anexar(Observador observador)
        {
            observadores.Add(observador);
        }

        public void Desanexar(Observador observador)
        {
            observadores.Remove(observador);
        }

        public void Notificar()
        {
            foreach (var item in observadores)
                item.Update();

        }
    }
}
