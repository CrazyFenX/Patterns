using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    /// <summary>
    /// Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.
    /// </summary>
    class BaseStructure
    {
        
    }

    abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }
        public abstract void Operation1();
        public abstract void Operation2();
    }

    class ConcreteClass : AbstractClass
    {
        public override void Operation1()
        {
        }

        public override void Operation2()
        {
        }
    }
}
