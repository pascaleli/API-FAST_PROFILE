using System.Collections.Generic;
using Fast_P_T_Profile.Models;

namespace Fast_P_T_Profile.Data
{
    public interface IProfileRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommand(Command cmd);
   }
}