using System;
using System.Collections.Generic;
using System.Linq;
using Fast_P_T_Profile.Models;

namespace Fast_P_T_Profile.Data
{
    public class MySQLProfileRepo : IProfileRepo
    {
        private CommanderContext _context;

        public MySQLProfileRepo(CommanderContext context)
        { _context = context;
        }

        public void CreateCommand(Command cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command GetCommandById(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
          return (_context.SaveChanges() >= 0);
        }
    }
}