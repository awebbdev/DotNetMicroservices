using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepo
    {
        bool SaveChanges();
        //Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform platform);
        bool PlatformExists(int platformId);

        //Commands
        IEnumerable<Command> GetAllCommandsByPlatformId(int platformId);
        Command GetCommandById(int platformId, int commandId);
        void CreateCommand(Command command);

    }
}