using UnityEngine;

[CreateAssetMenu(fileName = "Magnet_", menuName = "Powerups/Magnet")]
public class MagnetSO : ScriptableObject
{
    public bool Active;
    public float Duration = 5.5f;
    public float Range = 2.5f;

    public int Level;
    public int Price;

    public MagnetSO Upgrade;
    public bool CanUpgrade => Upgrade != null;
}
