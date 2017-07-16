using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongMinutesException : InvalidSongLengthException
    {
        private const string _message = "Song minutes should be between 0 and 14.";
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        public InvalidSongMinutesException()
            : base(_message)
        {
        }

        public InvalidSongMinutesException(string message)
            : base(message)
        {
        }
    }
}
