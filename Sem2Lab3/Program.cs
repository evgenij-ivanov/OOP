using System;

namespace Sem2Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();
            container.Command = new AddCommand(container, "a");
            container.ExecuteCommand();
            container.Show();
            container.ExecuteCommand();
            container.Show();
            container.Command = new AddCommand(container, "b");
            container.ExecuteCommand();
            container.Show();
            container.Command = new UpdateCommand(container, "c");
            container.ExecuteCommand();
            container.Show();
            container.Command = new RemoveCommand(container);
            container.ExecuteCommand();
            container.Show();
            container.Undo();
            container.Show();
            container.Undo();
            container.Show();
            container.Undo();
            container.Show();
            container.Undo();
            container.Show();
            container.Undo();
            container.Show();
        }
    }
}
