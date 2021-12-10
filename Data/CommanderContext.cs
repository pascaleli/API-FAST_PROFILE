using Fast_P_T_Profile.Models;
using Microsoft.EntityFrameworkCore;

namespace Fast_P_T_Profile.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }

        public DbSet<Command> Commands { get; set; }
    }
}