using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sem2Lab3
{
    public class RemoveCommand : Command
    {
        public RemoveCommand(Container container) : base(container)
        { }

        public override object Clone()
        {
            var command = new RemoveCommand(_container)
            {
                backup = backup
            };
            return command;
        }

        public override void Execute()
        {
            if (_container.Strings.Count == 0)
            {
                Console.WriteLine("Nothing to remove");
                return;
            }
            SaveBackup();
            _container.Strings.Remove(_container.Strings.Last());
        }
    }
}
