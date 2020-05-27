using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sem2Lab3
{
    public class UpdateCommand : Command
    {
        private string _param;

        public UpdateCommand(Container container, string param) : base(container)
        {
            _param = param;
        }

        public override object Clone()
        {
            var command = new UpdateCommand(_container, _param)
            {
                backup = backup
            };
            return command;
        }

        public override void Execute()
        {
            if (_container.Strings.Count == 0)
            {
                Console.WriteLine("Nothing to update");
                return;
            }
            SaveBackup();
            _container.Strings.Remove(_container.Strings.Last());
            _container.Strings.Add(_param);
        }
    }
}
