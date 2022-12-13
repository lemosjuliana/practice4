using System;


namespace Practice1
{
    /// <summary>
    /// A small cube with a different number of spots on each of its six sides.
    /// 
    /// The responsibility of Die is to keep track of the title, author, and length (in seconds) of the video. 
    /// </summary> 
    public class Comment
    {
        private string _nameComment;
        private string _textComment;

        /// <summary>
        /// Constructs a new instance of Comment with thespecified parameters
        /// </summary>
        public Comment(string nameComment, string textComment)
        {
            _nameComment = nameComment;
            _textComment = textComment;
        }
           public string GetNameComment()
        {
            return _nameComment;
        }
          public string GetTextComment()
        {
            return _textComment;
        }

    }
}