using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapp{
    [Route("api/Logger")]
    public class LogController:Controller{
        private ILoggerFactory _loggerFactory {get;set;}
        LogController(ILoggerFactory loggerFactory){
            _loggerFactory = loggerFactory;
        }
        [Route("Debug")]
        public void Get(){
            _loggerFactory.AddConsole(LogLevel.Debug);
        }
    }
}