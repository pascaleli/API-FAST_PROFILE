using System.Collections.Generic;
using AutoMapper;
//using AutoMapper;
using Fast_P_T_Profile.Data;
using Fast_P_T_Profile.Dtos;
//using Fast_P_T_Profile.Dtos;
//using Fast_P_T_Profile.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Command = Fast_P_T_Profile.Models.Command;

namespace Fast_P_T_Profile.Controllers
{
    // API COMMANDS 
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly IProfileRepo _repository;
        private readonly IMapper _mapper;

        //  private readonly IMapper _mapper;

        public CommandsController(IProfileRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        } 
        //private readonly MockProfileRepo _repository = new MockProfileRepo();
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<CommandReadDto>> GetAllcommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));

        }
        //GET api/commands/{}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int Id)
        {
            var commandItem = _repository.GetCommandById(Id);
            if (commandItem != null)
            {
            return Ok(_mapper.Map<CommandReadDto>(commandItem));
            }
            return NotFound();
        }
        //POST api/commands/  ==> tHIS IS TO CREate new profile
        [HttpPost]

        public ActionResult <CommandReadDto> CreateCommand(CommandCreateDto commandCreateDtos)
        {
            var CommandModel = _mapper.Map<Command>(commandCreateDtos);
            _repository.CreateCommand(CommandModel);
            _repository.SaveChanges();

            var commandReadDto = _mapper.Map<CommandReadDto>(CommandModel);
            return Ok(commandReadDto);
        }
    }
}