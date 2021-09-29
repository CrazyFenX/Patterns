using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class BaseStructure
    {
    }
    /// <summary>
    /// Хранитель, который сохраняет состояние объекта Originator 
    /// и предоставляет полный доступ только этому объекту Originator
    /// </summary>
    class Memento
    {
        public string State { get; private set; }
        public Memento(string state)
        {
            this.State = state;
        }
    }

    /// <summary>
    /// Выполняет только функцию хранения объекта Memento, в то же время 
    /// у него нет полного доступа к хранителю и никаких других операций над 
    /// хранителем, кроме собственно сохранения, он не производит
    /// </summary>
    class Caretaker
    {
        public Memento Memento { get; set; }
    }

    /// <summary>
    /// Cоздает объект хранителя для сохранения своего состояния
    /// </summary>
    class Originator
    {
        public string State { get; set; }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public Memento CreateMemento()
        {
            return new Memento(State);
        }
    }
}
