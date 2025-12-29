using UnityEngine;

[CreateAssetMenu(fileName = "PowerupManager", menuName = "Scriptable Objects/PowerupManager")]
public class PowerupManager : ScriptableObject
{
    [SerializeField] MagnetSO _magnet;

    public MagnetSO Magnet
    {
        get { return _magnet; }
        set
        {
            _magnet = value;
            PlayerPrefs.SetString("MagnetLevel", _magnet.name);
            Debug.Log(_magnet.name + " has been saved in PlayerPrefs");
        }
    }

    public bool reset;
    void Reset()
    {
        PlayerPrefs.SetString("BatteryLevel", "Battery_lvl1");
        PlayerPrefs.SetString("MagnetLevel", "Magnet_lvl1");
    }
    public void Init()
    {
        if (reset)
            Reset();

        //Read current powerup level from PlayerPrefs on startup
        // Stay at default if not found
        MagnetSO tmp2 = Resources.Load<MagnetSO>(PlayerPrefs.GetString("MagnetLevel"));
        if (tmp2 != null)
        {
            _magnet = tmp2;
            Debug.Log("Magnet: " + tmp2.name + " has been loaded!");
        }
    }
}
