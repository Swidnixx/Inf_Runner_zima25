using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    #region SINGLETON
    public static GameManager Instance;
    private void Awake()
    {
        if(Instance != null)
        {
            Debug.LogError("Multiple GameManagers in the Scene!");
        }
        Instance = this;
    }
    #endregion

    public PowerupManager powerupManager;
    public MagnetSO magnet => powerupManager.Magnet;

    public GameObject gameOverPanel;
    public TMP_Text scoreText;
    public TMP_Text coinsText;
    float score = 0;
    int coins = 0;

    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        coinsText.text = coins.ToString();

        magnet.Active = false;
    }

    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = score.ToString("f2");
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void AddCoin()
    {
        coins++;
        coinsText.text = coins.ToString();
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void ActivateMagnet()
    {
        magnet.Active = true;
        Invoke(nameof(CancelMagnet), magnet.Duration);
    }

    void CancelMagnet()
    {
        magnet.Active = false;
    }
}
