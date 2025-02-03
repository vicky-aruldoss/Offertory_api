using Newtonsoft.Json;
using Offertory_model;
using Offertory_Service_Contract;
using SuperConvert.Extensions;

namespace Offertory_service;


public class CsvConvertor : ICsvConvertor
{
    public List<T> ConvertToCsv<T>(string filePath)
    {
        string jsonFromCsv = ExcelConverter.CsvToJson(filePath);
        Console.Write(jsonFromCsv);
        var data = JsonConvert.DeserializeObject<List<T>>(jsonFromCsv);
        return data;
    }
}