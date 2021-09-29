using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    class BaseStructure
    {

        /// <summary>
        /// определяет интерфейс класса, объекты которого надо создавать
        /// </summary>
        abstract class Product
        { }

        /// <summary>
        /// реализация класса Product
        /// </summary>
        class ConcreteProductA : Product
        { }

        /// <summary>
        /// реализация класса Product
        /// </summary>
        class ConcreteProductB : Product
        { }

        /// <summary>
        /// определяет абстрактный фабричный метод FactoryMethod(), который возвращает объект Product
        /// </summary>
        abstract class Creator
        {
            public abstract Product FactoryMethod();
        }

        /// <summary>
        /// Реализация Creator под конкретный класс Product
        /// </summary>
        class ConcreteCreatorA : Creator
        {
            public override Product FactoryMethod() { return new ConcreteProductA(); }
        }

        class ConcreteCreatorB : Creator
        {
            public override Product FactoryMethod() { return new ConcreteProductB(); }
        }

    }
}
