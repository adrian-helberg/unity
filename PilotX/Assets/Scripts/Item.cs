using System.Collections.Generic;

public class Item
{
	public List<Stat> Stats;
	public string ObjectSlug;

	public Item(List<Stat> stats, string objectSlug)
	{
		Stats = stats;
		ObjectSlug = objectSlug;
	}
}
