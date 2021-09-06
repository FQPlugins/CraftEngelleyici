using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraftEngelleyici
{
    public class Config : IRocketPluginConfiguration
    {
        public void LoadDefaults()
        {
            craftableItems = new List<craftItem>
            {
                new craftItem
                {
                    Permission = "asd",
                    item = new List<ushort>
                    {
                        141,
                        143
                    }
                }
            };
        }

        public List<craftItem> craftableItems = new List<craftItem>(); 
    }
}
