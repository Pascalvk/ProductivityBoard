namespace ProductivityBoard.Classes.API
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public List<Board> Boards { get; set; } = new();
    }

    public class Board
    {
        public int BoardId { get; set; }
        public string BoardName { get; set; }
        public int UserID { get; set; }
        public List<Item> Items { get; set; } = new();
    }

    public class Item
    {
        public int? ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int StatusId { get; set; }
        public int BoardId { get; set; }
        public List<StatusItem> StatusItems { get; set; } = new();

    }

    public class StatusItem
    {
        public int StatusItemId { get; set; }
        public string StatusName { get; set; }
    }
}
