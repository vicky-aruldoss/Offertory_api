using Offertory_service;

namespace Offertory_tests;

public class UnitTest1
{
    private Service1 _service;
    public UnitTest1()
    {
        _service  = new Service1();
    }
    [Fact]
    public void Test1()
    {
        var result = _service.Test_fn();
        Assert.Equal("this is a test",result);
    }
}