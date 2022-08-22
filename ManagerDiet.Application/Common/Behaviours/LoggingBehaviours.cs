using MediatR.Pipeline;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagerDiet.Application.Common.Behaviours
{
    public class LoggingBehaviours<TRequest> : IRequestPreProcessor<TRequest>
    {
        private readonly ILogger _logger;   
        public LoggingBehaviours(ILogger<TRequest> logger)
        {
            _logger = logger;
        }
        public async Task Process(TRequest request, CancellationToken cancellationToken)
        {
            var requestName = typeof(TRequest).Name;

            _logger.LogInformation("DietManager Request: {Name} {@Request}",
                requestName, request);
        }
    }
}
