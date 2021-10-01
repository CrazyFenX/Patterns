using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    //Мост (Bridge) - структурный шаблон проектирования, который позволяет
    //отделить абстракцию от реализации таким образом, чтобы и абстракцию,
    //и реализацию можно было изменять независимо друг от друга.
    class BaseStructure
    {
    }
    /// <summary>
    /// Польуется классом Abstraction
    /// </summary>
    class Client
    {
        static void Main()
        {
            Abstraction abstraction;
            abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();
            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();
        }
    }
    /// <summary>
    /// Oпределяет базовый интерфейс и хранит ссылку на объект Implementor. Выполнение операций в Abstraction делегируется методам объекта Implementor
    /// </summary>
    abstract class Abstraction
    {
        protected Implementor implementor;
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public Abstraction(Implementor imp)
        {
            implementor = imp;
        }
        public virtual void Operation()
        {
            implementor.OperationImp();
        }
    }
    /// <summary>
    /// Implementor: определяет базовый интерфейс для конкретных реализаций. Как правило, Implementor определяет только примитивные операции. Более сложные операции, которые базируются на примитивных, определяются в Abstraction
    /// </summary>
    abstract class Implementor
    {
        public abstract void OperationImp();
    }
    /// <summary>
    /// RefinedAbstraction: уточненная абстракция, наследуется от Abstraction и расширяет унаследованный интерфейс
    /// </summary>
    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor imp)
            : base(imp)
        { }
        public override void Operation()
        {
        }
    }
    /// <summary>
    /// Конкретные реалиации Implementor                                                                                                                                                                                                                                                                                                                                                                                        
    /// </summary>
    class ConcreteImplementorA : Implementor
    {
        public override void OperationImp()
        {
        }
    }

    class ConcreteImplementorB : Implementor
    {
        public override void OperationImp()
        {
        }
    }
}
