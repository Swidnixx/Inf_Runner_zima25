using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject shop;

    public void Play()
    {
        SoundManager.Instance.PlayClick();
        SceneManager.LoadScene(1);
    }

    public void GoToShop()
    {
        SoundManager.Instance.PlayClick();
        menu.SetActive(false);
        shop.SetActive(true);
    }

    public void GoToMenu()
    {
        SoundManager.Instance.PlayClick();
        menu.SetActive(true);
        shop.SetActive(false);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
