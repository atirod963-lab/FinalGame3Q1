    using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public void TakeDamage(DataPlayer dataplayer ,int amount)
    {
        dataplayer.Health -= amount;
        Debug.Log($"{dataplayer.PlayerName} took {amount} damage. Health: {dataplayer.Health}");
        if (dataplayer.Health <= 0)
        {
            Debug.Log($"{dataplayer.PlayerName} has been defeated!");
        }
    }
}
