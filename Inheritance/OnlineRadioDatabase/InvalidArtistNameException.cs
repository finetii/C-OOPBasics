using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadioDatabase
{
    class InvalidArtistNameException : InvalidSongException
    {
        private const string _message = "Artist name should be between 3 and 20 symbols.";
        public override string Message
        {
            get
            {
                return _message;
            }
        }
        public InvalidArtistNameException()
            : base(_message)
        {
        }

        public InvalidArtistNameException(string message)
            :base(message)
        {     
        }
    }
}
