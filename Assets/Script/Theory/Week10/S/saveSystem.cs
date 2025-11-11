using UnityEngine;

public class saveSystem : MonoBehaviour
{
    public void SaveProgress(DataPlayer dataplayer)
    {
        Debug.Log($"Saving game for {dataplayer.PlayerName} to local file...");
        // Logic for saving player data to a file
    }
}
