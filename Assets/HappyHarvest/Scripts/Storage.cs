using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyHarvest
{
    public class Storage
    {
        public List<InventorySystem.InventoryEntry> Content { get; private set; }

        public Storage()
        {
            Content = new List<InventorySystem.InventoryEntry>();
        }

        public void Store(InventorySystem.InventoryEntry entry)
        {
            var idx = Content.FindIndex(inventoryEntry => inventoryEntry.Item.Key == entry.Item.Key);
            if (idx != -1)
            {
                Content[idx].StackSize += entry.StackSize;
            }
            else
            {
                Content.Add(new InventorySystem.InventoryEntry()
                {
                    Item = entry.Item,
                    StackSize = entry.StackSize
                });
            }
        }

        public int Retrieve(int contentIndex, int amount)
        {
            Debug.Assert(contentIndex < Content.Count, "Tried to retrieve a non existing entry from storage");

            int actualAmount = Mathf.Min(amount, Content[contentIndex].StackSize);

            Content[contentIndex].StackSize -= actualAmount;

            return actualAmount;
        }
    }
}
