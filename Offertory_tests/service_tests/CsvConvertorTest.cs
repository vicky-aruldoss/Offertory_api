using Offertory_Service_Contract;
using Offertory_service;
using Offertory_tests.Fixtures;
using Xunit.Abstractions;
using Xunit.Microsoft.DependencyInjection.Abstracts;

namespace Offertory_tests.service_tests;

public class CsvConvertorTest 
{
    
    [Fact]
    public void TestCSV()
    {
        var csvConvertor = new CsvConvertor();
        // var csvConvertor = _fixture.GetService<ICsvConvertor>(_testOutputHelper);
        var result = csvConvertor.ConvertToCsv<Offertory_model.OfferingDetails>("./Data/chritmas_offering.csv");
        Assert.NotNull(result);
        
    }

}