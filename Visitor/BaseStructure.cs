﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    class BaseStructure
    {
        void Main()
        {
            var structure = new ObjectStructure();
            structure.Add(new ElementA());
            structure.Add(new ElementB());
            structure.Accept(new ConcreteVisitor1());
            structure.Accept(new ConcreteVisitor2());
        }
    }
    /// <summary>
    /// интерфейс посетителя, который определяет метод Visit()
    /// для каждого объекта Element
    /// </summary>
    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elemA);
        public abstract void VisitElementB(ElementB elemB);
    }

    class ConcreteVisitor1 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }
    class ConcreteVisitor2 : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            elementA.OperationA();
        }
        public override void VisitElementB(ElementB elementB)
        {
            elementB.OperationB();
        }
    }

    class ObjectStructure
    {
        List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (Element element in elements)
                element.Accept(visitor);
        }
    }

    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
        public string SomeState { get; set; }
    }

    class ElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementA(this);
        }
        public void OperationA()
        { }
    }

    class ElementB : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitElementB(this);
        }
        public void OperationB()
        { }
    }

    //Паттерн Посетитель (Visitor) позволяет определить
    //операцию для объектов других классов без изменения этих классов.
    //При использовании паттерна Посетитель определяются две
    //иерархии классов: одна для элементов, для которых надо
    //определить новую операцию, и вторая иерархия для посетителей,
    //описывающих данную операцию.

    //Когда использовать данный паттерн?

    //Когда имеется много объектов разнородных классов с разными интерфейсами, и требуется выполнить ряд операций над каждым из этих объектов
    //Когда классам необходимо добавить одинаковый набор операций без изменения этих классов
    //Когда часто добавляются новые операции к классам, при этом общая структура классов стабильна и практически не изменяется
}
