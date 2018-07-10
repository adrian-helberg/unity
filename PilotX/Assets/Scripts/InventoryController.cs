using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
	public PlayerWeaponController PlayerWeaponController;
	public Item Sword;

	void Start()
	{
		PlayerWeaponController = GetComponent<PlayerWeaponController>();
		var swordStats = new List<Stat>
		{
			new Stat(6, "POWER", "Your power level")
		};
		
		Sword = new Item(swordStats, "sword");
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.V))
		{
			PlayerWeaponController.EquipWeapon(Sword);
		}
	}
}
