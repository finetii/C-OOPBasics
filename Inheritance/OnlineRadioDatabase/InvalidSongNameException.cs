using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongNameException : InvalidSongException
    {
        private const string _message = "Song name should be between 3 and 30 symbols.";
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        public InvalidSongNameException()
            : base(_message)
        {
        }

        public InvalidSongNameException(string message)
            : base(message)
        {
        }
    }
}
