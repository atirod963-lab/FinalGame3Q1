using UnityEngine;

public class ShortSword : Weapon
{
    private void Awake()
    {
        weaponID = "ShortSword";
        ApplyLevelStats();
    }

    public override void ApplyLevelStats()
    {
        if (level == 1)
        {
            damage = 10f;
            attackRange = 1f;  // ระยะใกล้
        }
        else if (level == 2)
        {
            damage = 20f;       // เพิ่ม dmg
            attackRange = 2f;   // ระยะไกลขึ้นเท่าตัว
            Debug.Log("Upgarde");
        }

    }


}
