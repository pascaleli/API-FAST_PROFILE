using System.Collections.Generic;
using Fast_P_T_Profile.Models;

namespace Fast_P_T_Profile.Data
{
    public class MockProfileRepo : IProfileRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void createprofile(Command profile)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
             new Command{Id=0, Name="John Depus", Age="55", Position="CEO OF FAST PACE TRANSFER LTD"},
              new Command{Id=1, Name="PASCAL A TAMEKLOE", Age="26", Position="SOFTWARE DEVELOPER"},
               new Command{Id=4, Name="MERCY LADY G", Age="32", Position="DATA ANALYST"}
            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, Name="Boil an egg", Age="Boil water", Position="Kettle & Pan"};
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}