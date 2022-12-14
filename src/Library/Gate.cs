using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public abstract class Gate :IInput
    {
        public Gate (string name)
        {
            this.Name = name;
            this.Entrada = new Dictionary <string, IInput>(); 
        }
        public string Name {get; set;}

        public Dictionary <string, IInput> Entrada {get; set;}

        public void AgregarEntrada(string name, IInput valor)
        {
            Entrada.Add(name, valor);
        }
        public abstract bool Calcular();
    }
}