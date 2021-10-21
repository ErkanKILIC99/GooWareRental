using Newtonsoft.Json;

namespace DevCarRental.WinFormUI.Modules
{
    public static class JsonConverter
    {
        public static string ConvertDataToJson(object data)
        {
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }
    }
}
