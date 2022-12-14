using System;


namespace Practice1
{
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of the title, author, and length (in seconds) of the video. 
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
        /// Generates a new random value and calculates the points for the die.
        /// </summary>
        public string GetTitle()
        {
           return _title;
        }
         public string GetAuthor()
        {
            return _author;
        }

         public int GetLength()
        {
            return _length;
        }

           public void AddComment(Comment comment)
        {
            _comments.Add(comment);
        }

           public int GetNumberOfComment()
        {
            return _comments.Count;
        }

           public List<Comment> GetComments()
        {
            return _comments;
        }

    }
}