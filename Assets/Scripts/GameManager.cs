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

    public GameObject gameOverPanel;
    public TMP_Text scoreText;
    float score = 0;

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
}
