using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location 
    { 
      public int ID { get; set; }
      public string Name { get; set; }
      public string Description { get; set; }
      public Item ItemRequiredToEnter { get; set; }
      public Quest QuestAvailableHere { get; set; }
      public Monster MonsterLivingHere { get; set; }
      public Item PossibleItemsHere { get; set; }
      public Location LocationToNorth { get; set; }
      public Location LocationToEast { get; set; }
      public Location LocationToSouth { get; set; }
      public Location LocationToWest { get; set; }


        public Location(int id, string name, string description,
            Item requiredItem = null, Quest questAvailable = null,
            Monster monsterHere = null, Item possibleItemsHere = null)
        {
            ID = id;
            Name = name;
            Description = description;
            ItemRequiredToEnter = requiredItem;
            QuestAvailableHere = questAvailable;
            MonsterLivingHere = monsterHere;
            PossibleItemsHere = possibleItemsHere;
        }
    }
}
