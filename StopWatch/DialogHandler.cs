using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    public class DialogHandler
    {
        private Queue<string> lines = new Queue<string>();
        private List<string> flavorText = new List<string>();

        private static Random random = new Random();  
        public DialogHandler()
        {
            CreateLines();
            PopulateFlavorText();
        }

        public void CreateLines()
        {
            lines.Enqueue("Craigory: You're foolish for even showing your face...");
            lines.Enqueue("Hmmm, it turns out you can actually hit me...");
            lines.Enqueue("Fine, I'll show you a real fight!");
            lines.Enqueue("H-how did you survive? this can't be happening...");
        }
        public void PopulateFlavorText()
        {
            flavorText.Add("HEE HOO");
            flavorText.Add("You feel your sins crawling on your back");
            flavorText.Add("You feel like you're gonna have a bad time");
            flavorText.Add("Craigory approaches menacingly...");
            flavorText.Add("The wind is howling around you.");
            flavorText.Add("You feel like you made an oopsie...");
            flavorText.Add("You ponder what they will put on your gravestone");
        }

        public string PullFlavorText()
        {
            return flavorText[random.Next(flavorText.Count)];
        }

        public string PullNextLine()
        {
            return lines.Dequeue();
        }
    }
}
