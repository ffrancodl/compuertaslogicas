using System;
using System.Linq;

namespace Library
{
    public class OrGate : Gate
    {
        public OrGate (string Name) : base (Name)
        {

        }
        public override bool Calcular()
        {
            if (Entrada.Count != 2)
            {
                throw new NumeroEntradasException ("No tiene 2 entradas");
            }
        bool respuesta = false;
        foreach (var element in Entrada)
        {
            respuesta |= element.Value.Calcular();
        }
        return respuesta;
        }
    }
}