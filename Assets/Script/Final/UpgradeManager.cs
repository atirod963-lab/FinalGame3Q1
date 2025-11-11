using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public int killsRequired = 10;

    public PlayerWeaponHolder weaponHolder;
    public KillManager killManager;

    private void Update()
    {
        if (weaponHolder.currentWeapon == null)
            return;

        string id = weaponHolder.currentWeapon.weaponID;

        int kills = killManager.GetKills(id);

        if (kills >= killsRequired)
        {
            UpgradeWeapon(weaponHolder.currentWeapon);
            killManager.ResetKills(id);
        }
    }

    void UpgradeWeapon(Weapon weapon)
    {
        weapon.level++;
        weapon.ApplyLevelStats();

        Debug.Log($"Weapon {weapon.weaponID} upgraded to level {weapon.level}");
    }
}
