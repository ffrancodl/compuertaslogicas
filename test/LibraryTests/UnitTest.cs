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
        and.AgregarEntrada("A", l2);
        and.AgregarEntrada("B", l2);
        Assert.True (and.Calcular());
    }

    OrGate or = new OrGate("Or");
    AndGate and = new AndGate("And");
    NotGate not = new NotGate("Not");

    [Test]
    public void OrGateTest()
    {
        OrGate or = new OrGate ("Or");
        or.AgregarEntrada("A", l1);
        or.AgregarEntrada("B", l2);
        Assert.True (or.Calcular());
    }

    [Test]
    public void NotGateTest()
    {
        NotGate not = new NotGate ("Not");
        not.AgregarEntrada("A", l1);
        Assert.True (not.Calcular());
    }
} 
