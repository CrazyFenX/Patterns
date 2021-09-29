using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class BaseStructure
    {
    }
    /// <summary>
    /// Использует объекты Target для выполнения своих задач
    /// </summary>
    class Client
    {
        public void Request(Target target)
        {
            target.Request();
        }
    }
    // класс, к которому надо адаптировать другой класс
    /// <summary>
    /// Представляет объекты, которые используются клиентом
    /// </summary>
    class Target
    {
        public virtual void Request()
        { }
    }

    // Адаптер
    /// <summary>
    /// Собственно адаптер, который позволяет работать с объектами Adaptee как с объектами Target
    /// </summary>
    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }

    // Адаптируемый класс
    /// <summary>
    /// Представляет адаптируемый класс, который мы хотели бы использовать у клиента вместо объектов Target
    /// </summary>
    class Adaptee
    {
        public void SpecificRequest()
        { }
    }
}
