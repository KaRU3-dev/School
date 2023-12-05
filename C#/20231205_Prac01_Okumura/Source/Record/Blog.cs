using System;

namespace App.Record
{
    public record Blog
    {
        public string Title { get; init; }
        public string Content { get; init; }

        public Blog(string title, string content) => (Title, Content) = (title, content);

        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Content);
        }
    }
}
