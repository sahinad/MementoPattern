using System;

namespace MementoPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Text Editor Demo
            var textEditor = new Editor();
            var textEditorHistory = new History();

            textEditor.Content = "Hello";
            textEditorHistory.Push(textEditor.CreateState());

            textEditor.Content = "Hello World";
            textEditorHistory.Push(textEditor.CreateState());

            textEditor.Content = "Hello World!";
            textEditor.Restore(textEditorHistory.Pop());
            Console.WriteLine(textEditor.Content); // Hello World

            textEditor.Restore(textEditorHistory.Pop());
            Console.WriteLine(textEditor.Content); // Hello
        }
    }
}
