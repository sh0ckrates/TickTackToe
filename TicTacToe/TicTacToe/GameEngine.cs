using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TicTacToe
{
    public class GameEngine
    {
        private string[] WinningArray =
        {
            "123","456","789","147","258","369","159","357",
            "132","465","798","174","285","396","195","375",
            "213","546","987","714","528","963","591","753",
            "231","564","978","741","582","936","519","735",
            "321","654","879","471","825","639","951","537",
            "312","645","897","417","852","693","915","573",
        };

        public char[] CheckIfWon(List<char> playerPicks)
        {
            var results = Permute(playerPicks);

            foreach (var result in results)
            {
                if (WinningArray.Contains(result))
                {
                    return result.ToCharArray();
                }
            }
            return null;
        }
        public string[] Permute(List<char> characters)
        {
            List<string> strings = new List<string>();
            for (int i = 0; i < characters.Count; i++)
            {
                for (int j = i + 1; j < characters.Count; j++)
                {
                    for (int k = j + 1; k < characters.Count; k++)
                    {
                        strings.Add(new String(new char[] { characters[i], characters[j],characters[k] }));
                    }                  
                }
            }
            return strings.ToArray();
        }
    }
}
