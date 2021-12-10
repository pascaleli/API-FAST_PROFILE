using AutoMapper;
using Fast_P_T_Profile.Dtos;
using Fast_P_T_Profile.Models;

namespace Fast_P_T_Profile.Profiles
{
        public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            // from source  -> Target
            CreateMap<Command, CommandReadDto>();
            CreateMap<CommandReadDto, Command>();
        }
    }
}