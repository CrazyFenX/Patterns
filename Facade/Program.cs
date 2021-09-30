using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);

            Console.Read();
        }
    }
    // текстовый редактор
    /// <summary>
    /// Элемент сложной системы
    /// </summary>
    class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }
    /// <summary>
    /// Элемент сложной системы
    /// </summary>
    class Compiller
    {
        public void Compile()
        {
            Console.WriteLine("Компиляция приложения");
        }
    }
    /// <summary>
    /// Элемент сложной системы
    /// </summary>
    class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Выполнение приложения");
        }
        public void Finish()
        {
            Console.WriteLine("Завершение работы приложения");
        }
    }

    /// <summary>
    /// Фасад, предоставляющий интерфейс, упрощающий доступ к функционалу сложной системы
    /// </summary>
    class VisualStudioFacade
    {
        TextEditor textEditor;
        Compiller compiller;
        CLR clr;
        public VisualStudioFacade(TextEditor te, Compiller compil, CLR clr)
        {
            this.textEditor = te;
            this.compiller = compil;
            this.clr = clr;
        }
        public void Start()
        {
            textEditor.CreateCode();
            textEditor.Save();
            compiller.Compile();
            clr.Execute();
        }
        public void Stop()
        {
            clr.Finish();
        }
    }
    /// <summary>
    /// Польователь, управляющий слоной системой путе ваимодействия с фасадом
    /// </summary>
    class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
