using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string weaponID;   // เช่น "ShortSword", "LongSword"
    public int level = 1;

    public float damage;
    public float attackRange;

    public abstract void ApplyLevelStats(); // อัพเกรดค่าสเตตัส
}
