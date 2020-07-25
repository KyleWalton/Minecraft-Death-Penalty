using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MinecraftDeathPenalty
{
    class DeathToll
    {
        public void Calculate(int deathCount)
        {
            List<AttributeItem> attributeItemCollection = LoadItem();         
          

            //List <AttributeItem> cullRareityCollection = attributeItemCollection.Select


        }

        public List<AttributeItem> LoadItem()
        {
            List<AttributeItem> attributeCollection = new List<AttributeItem>();
            AttributeItem a1 = new AttributeItem { AttributeName = "Diamond", ImageFileName = "Diamond", Rarity = 4 };
            AttributeItem a2 = new AttributeItem { AttributeName = "Iron Ingot", ImageFileName = "Iron Ingot", Rarity = 3 };
            AttributeItem a3 = new AttributeItem { AttributeName = "Leather", ImageFileName = "Leather", Rarity = 2 };
            AttributeItem a4 = new AttributeItem { AttributeName = "Coal", ImageFileName = "Coal", Rarity = 2 };
            AttributeItem a5 = new AttributeItem { AttributeName = "Emerald", ImageFileName = "Emerald", Rarity = 5 };
            AttributeItem a6 = new AttributeItem { AttributeName = "Coal", ImageFileName = "Coal", Rarity = 2 };
            AttributeItem a7 = new AttributeItem { AttributeName = "Redstone", ImageFileName = "Redstone", Rarity = 3 };
            AttributeItem a8 = new AttributeItem { AttributeName = "Obsidian", ImageFileName = "Obsidian", Rarity = 4 };

            attributeCollection.Add(a1);
            attributeCollection.Add(a2);
            attributeCollection.Add(a3);
            attributeCollection.Add(a4);
            attributeCollection.Add(a5);
            attributeCollection.Add(a6);
            attributeCollection.Add(a7);
            attributeCollection.Add(a8);
            return attributeCollection;
        }
    }

}
