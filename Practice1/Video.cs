using System;


namespace Practice1
{
    /// <summary>
    /// A visual display.
    /// 
    /// The responsibility of Video is to keep track of the title, author, and length (in seconds) of the video. 
    /// </summary> 
    public class Video
    {
        private string _title;
        private string _author;
        private int _length;
        private List<Comment> _comments;


        /// <summary>
        /// Constructs a new instance of Video.
        /// </summary>
        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
            _comments = new List<Comment>();
        }

        /// <summary>
        /// Gets the title of the video.
        /// </summary>
        /// <returns>A title.</returns>
        public string GetTitle()
        {
            return _title;
        }

        /// <summary>
        /// Gets the author of the video.
        /// </summary>
        /// <returns>A author</returns>
        public string GetAuthor()
        {
            return _author;
        }

        /// <summary>
        /// Gets the length of the video.
        /// </summary>
        /// <returns>the length.</returns>
        public int GetLength()
        {
            return _length;
        }

        /// <summary>
        /// Adds new comments 
        /// </summary>
        /// <param name="comment">The comment made by the viewer.</param>
        public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }
        /// <summary>
        /// Gets the number of comments.
        /// </summary>
        /// <returns>the comment's count.</returns>
        public int GetNumberOfComment()
        {
            return _comments.Count;
        }
        /// <summary>
        /// Gets comments.
        /// </summary>
        /// <returns>the comments</returns>
        public List<Comment> GetComments()
        {
            return _comments;
        }

    }
}