namespace WhatsApp_App.Components.Models
{
    public class EntryCount
    {
        public string Content = "";
        public int Count = 0;
    }

    public class GraphDetails
    {
        public string GraphType = "";
        public string GraphTitle = "";
        public string? PopupLabel = "";
        public string? XLabel = "";
        public string? YLabel = "";

    }


    public class TileData
    {
        public string TileTitle = "";

        public GraphDetails? Graph;

        public string? Message = "";

        public string? TileStyle = "";

        public List<EntryCount> Data = [];


    }
}