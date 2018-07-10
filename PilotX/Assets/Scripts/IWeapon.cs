using System.Collections.Generic;

public interface IWeapon
{
	List<Stat> Stats { get; set; }
	void PerformAttack();
}
