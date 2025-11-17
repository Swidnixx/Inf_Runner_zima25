using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText;
    float score = 0;

    private void Update()
    {
        score += Time.deltaTime;
        scoreText.text = score.ToString();
    }
}
