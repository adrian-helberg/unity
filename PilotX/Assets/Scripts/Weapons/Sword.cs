using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
	public class Sword : MonoBehaviour, IWeapon
	{
		public List<Stat> Stats { get; set; }
		
		public void PerformAttack()
		{
			Debug.Log("Sword attacked");
		}
	}
}
