using System;
using System.Collections.Generic;

namespace Library
{
    public interface iGate
    {
        public void AgregarEntrada(bool valor, string Name);
        
        public void Calcular();
    }
}