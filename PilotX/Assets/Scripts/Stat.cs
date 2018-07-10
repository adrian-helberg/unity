using System.Collections.Generic;

/**
 * Representation of base stat
 */
public class Stat
{
    public List<StatBonus> StatBonusList;
    public int BaseValue;
    public string StatName;
    public string StatDescription;
    public int FinalValue;

    public Stat(int baseValue, string statName, string statDescription)
    {
        StatBonusList = new List<StatBonus>();
        BaseValue = baseValue;
        StatName = statName;
        StatDescription = statDescription;
    }

    public void AddStatBonus(StatBonus statBonus)
    {
        StatBonusList.Add(statBonus);
    }

    public void RemoveStatBonus(StatBonus statBonus)
    {
        StatBonusList.Remove(StatBonusList.Find(b => b.BonusValue == statBonus.BonusValue));
    }

    public int GetCalculatedStatValue()
    {
        StatBonusList.ForEach(b => FinalValue += b.BonusValue);
        FinalValue += BaseValue;
        
        return FinalValue;
    }
}