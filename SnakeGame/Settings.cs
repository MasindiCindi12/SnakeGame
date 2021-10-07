using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace SnakeGame
{
    class Settings
    {
        public static int width { get; set; }
        public static int Height { get; set; }
        public static string directions;
       
        public Settings()
        {
            width = 16;
            Height = 16;
            directions = "right";
           
        }
    }
}
