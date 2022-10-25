using Newtonsoft.Json;

namespace CoreBot.Utilities
{
    public class ToDoTask
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Task { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }

    }
}
