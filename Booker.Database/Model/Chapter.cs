
namespace Booker.Database.Model
{
    public enum ChapterType
    {
        Text,
        Image
    }

    public class Chapter : ModelBase
    {
        public string name { get; set; }

        public string bookid { get; set; }

        public string volume { get; set; }

        public int orderno { get; set; }

        public ChapterType type { get; set; }

        public string contenturl { get; set; }
    }
}
