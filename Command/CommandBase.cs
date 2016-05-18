using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserCommand
{
    public abstract class CommandBase : ICommand
    {
        public abstract void Execute();
        public abstract void UnExecute();
    }
}
