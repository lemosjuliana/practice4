using System;


namespace Practice1
{
    /// <summary>
    /// A comment made by a YouTube user.
    /// 
    /// The responsibility of Comment is to keep track of the person's name and the content of the comment (text).
    /// </summary> 
    public class Comment
    {
        private string _nameComment;
        private string _textComment;

        /// <summary>
        /// Constructs a new instance of Comment with the specified parameters.
        /// </summary>
        public Comment(string nameComment, string textComment)
        {
            _nameComment = nameComment;
            _textComment = textComment;
        }
        /// <summary>
        /// Gets the person's name.
        /// </summary>
        /// <returns> A name</returns>
           public string GetNameComment()
        {
            return _nameComment;
        }

        /// <summary>
        /// Gets the person's comment content.
        /// </summary>
        /// <returns>A text comment.</returns>
          public string GetTextComment()
        {
            return _textComment;
        }

    }
}