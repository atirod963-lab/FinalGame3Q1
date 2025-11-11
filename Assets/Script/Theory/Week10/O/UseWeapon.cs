using Theory.Week10;
using UnityEngine;


public class UseWeapon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("---- Bad Calculate Damage ----");
        Weapon sword = new Weapon(WeaponType.Sword, 10);
        Debug.Log($"Sword Damage: {BadCalculateDamage(sword)}"); // Output: Sword Damage: 15

    }
    public int GoodCalculateDamage(IBonusWeapon weapon)
    {
        int damage = weapon.GetDamage();
        return damage; // เรียกใช้เมธอดจาก interfaceโดยตรง

    }

    public int BadCalculateDamage(Weapon weapon)
    {
        int totalDamage = weapon.BaseDamage;
        if (weapon.Type == WeaponType.Sword)
        {
            totalDamage += 5; // âº¹ÑÊ´Òº
        }
        else if (weapon.Type == WeaponType.Bow)
        {
            totalDamage += 3; // âº¹ÑÊ¸¹Ù
        }
        else if (weapon.Type == WeaponType.Gun)
        {
            totalDamage += 10; // âº¹ÑÊ»×¹
        }
        // ¶éÒà¾ÔèÁ WeaponType.Axe µéÍ§ÁÒà¾ÔèÁ else if µÃ§¹Õé
        return totalDamage;
    }
    
}
