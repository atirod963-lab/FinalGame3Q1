using UnityEngine;

public class PlayerWeaponHolder : MonoBehaviour
{
    public Weapon currentWeapon;

    public void EquipWeapon(Weapon newWeapon)
    {
        currentWeapon = newWeapon;
    }
}
