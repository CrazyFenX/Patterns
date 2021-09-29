using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class BaseStructure
    {
        void Main()
        {
            Handler h1 = new ConcreteHandler1();
            Handler h2 = new ConcreteHandler2();
            h1.Successor = h2;
            h1.HandleRequest(2);
        }
    }
    /// <summary>
    /// Определяет интерфейс для обработки запроса. Также может определять ссылку на следующий обработчик запроса
    /// </summary>
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void HandleRequest(int condition);
    }

    /// <summary>
    /// конкретные обработчики, которые реализуют функционал для обработки запроса.
    /// При невозможности обработки и наличия ссылки на следующий 
    /// обработчик, передают запрос этому обработчику
    /// </summary>
    class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // некоторая обработка запроса

            if (condition == 1)
            {
                // завершение выполнения запроса;
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }

    class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int condition)
        {
            // некоторая обработка запроса

            if (condition == 2)
            {
                // завершение выполнения запроса;
            }
            // передача запроса дальше по цепи при наличии в ней обработчиков
            else if (Successor != null)
            {
                Successor.HandleRequest(condition);
            }
        }
    }
}
