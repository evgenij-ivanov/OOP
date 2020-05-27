using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    public class AddCommand : Command
    {
        string _param;

        public AddCommand(Container container, string param) : base(container)
        {
            _param = param;
        }

        public override object Clone()
        {
            var command = new AddCommand(_container, _param)
            {
                backup = backup
            };
            return command;
        }

        public override void Execute()
        {
            SaveBackup();
            _container.Strings.Add(_param);
        }
    }
}
