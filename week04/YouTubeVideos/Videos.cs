using System.Collections.Generic;

namespace YouTubeVideos
{
    public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int LengthSeconds { get; }

        private readonly List<Comment> _comments = new List<Comment>();

        public Video(string title, string author, int lengthSeconds)
        {
            Title = title;
            Author = author;
            LengthSeconds = lengthSeconds;
        }

        public void AddComment(Comment comment)
        {
            if (comment != null)
            {
                _comments.Add(comment);
            }
        }

        public int GetCommentCount()
        {
            return _comments.Count;
        }

        public IReadOnlyList<Comment> GetComments()
        {
            return _comments.AsReadOnly();
        }
    }
}
