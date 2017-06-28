using static Newtonsoft.Json.JsonConvert;

namespace AzureLibrary
{
    public class Thing
    {
        public int Get(int left, int right) =>
            DeserializeObject<int>($"{left + right}");
    }
}