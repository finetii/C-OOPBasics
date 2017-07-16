using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidSongException : Exception
    {
        private const string _message = "Invalid song.";
        public override string Message
        {
            get
            {
                return _message;
            }
        }

        public InvalidSongException()
            :base(_message)
        {
        }
        
        public InvalidSongException(string message)
            : base (message)
        {
        }
    }
}
