using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Offertory_Service_Contract;
using Offertory_service;
using Xunit.Microsoft.DependencyInjection;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Offertory_tests.Fixtures;

public class TestProjectFixture : TestBedFixture
{

    protected override void AddServices(IServiceCollection services, IConfiguration? configuration)
        => services.AddTransient<ICsvConvertor, CsvConvertor>();

    protected override IEnumerable<TestAppSettings> GetTestAppSettings()
    {
        yield return new() { Filename = "appsettings.json", IsOptional = false };
    }

    protected override ValueTask DisposeAsyncCore()
        => new();
}