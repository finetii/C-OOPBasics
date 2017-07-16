using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mordor_sCrueltyPlan
{
    class Gandalf
    {
        private int _happiness = 0;
        
        public enum Moods {Angry, Sad, Happy, JavaScript};
        
        public string Mood
        {
            get
            {                
                if(_happiness < -5)
                {
                    return Moods.Angry.ToString();
                }
                else if (_happiness >= -5 && _happiness < 0)
                {
                    return Moods.Sad.ToString();
                }
                else if (_happiness >= 0 && _happiness < 15)
                {
                    return Moods.Happy.ToString();
                }
                else
                {
                    return Moods.JavaScript.ToString();
                }
            }            
        }

        public int Happiness
        {
            get
            {
                return _happiness;
            }
            
        }

        public void EatFood(string food)
        {
            switch (food.ToLower())
            {
                case "cram":
                    _happiness += 2;
                    break;
                case "lembas":
                    _happiness += 3;
                    break;
                case "apple":
                    _happiness += 1;
                    break;
                case "melon":
                    _happiness += 1;
                    break;
                case "honeycake":
                    _happiness += 5;
                    break;
                case "mushrooms":
                    _happiness -= 10;
                    break;
                default:
                    _happiness -= 1;
                    break;
            }
        }
        
    }
}
