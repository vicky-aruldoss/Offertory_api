namespace Offertory_Service_Contract;

public interface ICsvConvertor
{
    public List<T> ConvertToCsv<T>(string filePath);
}