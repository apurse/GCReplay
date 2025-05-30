namespace WhatsApp_App.Components.Models
{
    public class EntryCount
    {
        public string Content = "";
        public int Count = 0;
    }

    public class GraphDetails
    {
        public string Type = "";
        public string Title = "";
        public string? PopupLabel = "";
        public string? XLabel = "";
        public string? YLabel = "";

        public List<EntryCount> Data { get; set; } = [];

    }
}