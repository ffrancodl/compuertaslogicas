using System;
using Library;
using NUnit.Framework;

namespace LibraryTests;

public class Tests
{
    LogicInput l1 = new LogicInput(false);
    LogicInput l2 = new LogicInput(true);
    [Test]
    public void AndGateTest()
    {
        AndGate and = new AndGate ("And");
        and.AgregarEntrada("A", l1);
        and.AgregarEntrada("B", l2);
        Assert.True (and.Calcular());
    }

} 
