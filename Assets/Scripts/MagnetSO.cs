using UnityEngine;

[CreateAssetMenu(fileName = "Magnet_", menuName = "Powerups/Magnet")]
public class MagnetSO : ScriptableObject
{
    public bool Active;
    public float Duration = 5.5f;
    public float Range = 2.5f;

}
