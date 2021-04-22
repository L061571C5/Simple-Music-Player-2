using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Music_Player_2
{
    class MusicData
    {
        public static List<string> queue = new List<string>();
        public static List<string> previous = new List<string>();
        public static float volume = 1f;
        public static string title;
        public static string artist;
        public static string album;
        public static double posMs;
        public static double totalMs;
    }
}
