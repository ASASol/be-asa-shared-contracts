using be_asa_shared_contracts.Interfaces;
using Dapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Data;

namespace be_asa_shared_infrastructure.Integrations
{
    public class GlobalTimeRefreshService : BackgroundService
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ILogger<GlobalTimeRefreshService> _logger;

        public GlobalTimeRefreshService(IServiceProvider serviceProvider, ILogger<GlobalTimeRefreshService> logger)
        {
            _serviceProvider = serviceProvider;
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    using var scope = _serviceProvider.CreateScope();
                    var dapperContext = scope.ServiceProvider.GetService<IDapperContext>();
                    var timeContext = scope.ServiceProvider.GetRequiredService<IGlobalTimeContext>();

                    if (dapperContext != null)
                    {
                        using var conn = dapperContext.CreateConnection();

                        var dbTime = await conn.QueryFirstOrDefaultAsync<DateTimeOffset>(
                            "sp_GetSystemTimeUTC",
                            commandType: CommandType.StoredProcedure);

                        if (dbTime != default)
                        {
                            timeContext.SetDatabaseUtc(dbTime);
                            _logger.LogInformation("UTC SQL: {DbTime}", dbTime);
                        }
                    }
                    else
                    {
                        _logger.LogWarning("IDapperContext Not Found");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogWarning("Error UTC SQL: {Msg}", ex.Message);
                }

                await Task.Delay(TimeSpan.FromMinutes(5), stoppingToken);
            }
        }
    }
}
