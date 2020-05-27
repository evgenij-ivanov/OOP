using System;
using System.Collections.Generic;
using System.Text;

namespace Sem2Lab3
{
    public abstract class Command : ICloneable
    {
        protected Container _container;
        protected List<string> backup;

        public Command(Container container)
        {
            _container = container;
        }

        public abstract object Clone();

        public abstract void Execute();

        public void SaveBackup()
        {
            backup = new List<string>(_container.Strings);
        }

        public void Undo()
        {
            _container.Strings = backup;
        }
    }
}
