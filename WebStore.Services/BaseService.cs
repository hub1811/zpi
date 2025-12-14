using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.Services
{
    public class BaseService
    {
         protected readonly ILogger<BaseService> _logger;

        public BaseService(ILogger<BaseService> logger)
        {
            _logger = logger;
        }
    }
}