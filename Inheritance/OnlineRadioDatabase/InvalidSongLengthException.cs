using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongLengthException : InvalidSongException
    {
        private const string _message = "Invalid song length.";
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        public InvalidSongLengthException()
            :base(_message)
        {
        }
        public InvalidSongLengthException(string message)
            : base(message)
        {
        }
    }
}
