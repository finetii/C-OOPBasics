using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongSecondsException : InvalidSongLengthException
    {
        private const string _message = "Song seconds should be between 0 and 59.";
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        public InvalidSongSecondsException()
            : base(_message)
        {
        }

        public InvalidSongSecondsException(string message)
            : base(message)
        {
        }
    }
}
