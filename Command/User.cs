using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace UserCommand
{
    public class User
    {
        static User _user = null;
        public static User GetInstance()
        {
            if (_user == null)
            {
                _user = new User();
            }
            return _user;
        }


        // Initializers
        private List<CommandBase> _commands = new List<CommandBase>();
        private int _current = 0;
 
        public void Redo(int levels)
        {
            
        }
 
        public void Undo(int levels)
        {
            
        }

        public void Command(CommandBase command)
        {
            command.Execute();


            _commands.RemoveRange(_current, _commands.Count - _current);
            _commands.Add(command);
            _current++;
        }
    }
}
