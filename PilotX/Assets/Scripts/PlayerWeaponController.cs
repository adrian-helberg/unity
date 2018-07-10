using Stats;
using UnityEngine;

public class PlayerWeaponController : MonoBehaviour
{
	public GameObject playerHand;
	public GameObject EquippedWeapon;

	private IWeapon equippedWeapon;
	private CharacterStats CharacterStats;

	void Start()
	{
		CharacterStats = GetComponent<CharacterStats>();
	}

	public void EquipWeapon(Item itemToEquip)
	{
		if (EquippedWeapon != null)
		{
			CharacterStats.RemoveStatBonus(EquippedWeapon.GetComponent<IWeapon>().Stats);
			Destroy(playerHand.transform.GetChild(0).gameObject);
		}

		EquippedWeapon = Instantiate(
			Resources.Load<GameObject>("Weapons/" + itemToEquip.ObjectSlug), 
			playerHand.transform.position, 
			playerHand.transform.rotation
		);

		equippedWeapon = EquippedWeapon.GetComponent<IWeapon>();
		equippedWeapon.Stats = itemToEquip.Stats;
		EquippedWeapon.transform.SetParent(playerHand.transform);
		EquippedWeapon.transform.rotation = playerHand.transform.rotation;
		
		CharacterStats.AddStatBonus(itemToEquip.Stats);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			PerformWeaponAttack();
		}
	}

	public void PerformWeaponAttack()
	{
		equippedWeapon.PerformAttack();
	}
}
