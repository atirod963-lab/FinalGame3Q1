using UnityEngine;
using UnityEngine.UIElements;

public class playMovement : MonoBehaviour
{
    public void Move(DataPlayer dataplayer ,float deltaX, float deltaY)
    {
        dataplayer.PositionX += deltaX;
        dataplayer.PositionY += deltaY;
        Debug.Log($"{dataplayer.PlayerName} moved to ({dataplayer.PositionX}, {dataplayer.PositionY})");
    }
}
