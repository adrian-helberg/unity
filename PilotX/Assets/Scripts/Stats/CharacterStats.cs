using System.Collections.Generic;
using UnityEngine;

namespace Stats
{
    public class CharacterStats : MonoBehaviour
    {
        public List<Stat> Stats = new List<Stat>();

        void Start()
        {
            Stats.Add(new Stat(4, "POWER", "Your Power level"));
            Stats.Add(new Stat(50, "HP", "Your hit points"));
            Stats.Add(new Stat(13, "DEF", "Your defense"));
        }

        public void AddStatBonus(List<Stat> statList)
        {
            foreach (var stat in statList)
            {
                Stats.Find(s => s.StatName == stat.StatName)
                    .AddStatBonus(
                        new StatBonus(stat.BaseValue, stat.StatName)
                    );
            }
        }
        
        public void RemoveStatBonus(List<Stat> statList)
        {
            foreach (var stat in statList)
            {
                Stats.Find(s => s.StatName == stat.StatName)
                    .RemoveStatBonus(
                        new StatBonus(stat.BaseValue, stat.StatName)
                    );
            }
        }
    }
}