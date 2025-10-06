using System.Collections.Generic;
using UnityEngine;

namespace HappyHarvest
{
    public interface IDatabaseEntry
    {
        string Key { get; }
    }
    
    public abstract class BaseDatabase<T> : ScriptableObject where T: class, IDatabaseEntry
    {
        [SerializeReference]
        public List<T> Entries; 

        private Dictionary<string, T> m_LookupDictionnary;

        public T GetFromID(string uniqueID)
        {
            if (m_LookupDictionnary.TryGetValue(uniqueID, out var entry))
            {
                return entry;
            }

            return null;
        }

        public void Init()
        {
            m_LookupDictionnary = new Dictionary<string, T>();
            foreach (var entry in Entries)
            {
                if (entry == null)
                {
                    continue;
                }
                m_LookupDictionnary.TryAdd(entry.Key, entry);
            }
        }
    }
}