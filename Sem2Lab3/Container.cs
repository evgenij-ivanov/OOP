using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sem2Lab3
{
    public class Container
    {
        private List<Command> history;

        public Command Command
        {
            get;
            set;
        }

        public List<string> Strings
        {
            get;
            set;
        }

        public Container()
        {
            Strings = new List<string>();
            history = new List<Command>();
        }

        public void ExecuteCommand()
        {
            Command.Execute();
            history.Add((Command) Command.Clone());
        }

        public void Undo()
        {
            if (history.Count == 0)
                return;
            history.Last().Undo();
            history.Remove(history.Last());
        }

        public void Show()
        {
            if (Strings.Count == 0)
            {
                Console.Write("Empty");
            }    
            foreach (var str in Strings)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
        }
    }
}
