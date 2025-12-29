using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject shop;

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToShop()
    {
        menu.SetActive(false);
        shop.SetActive(true);
    }

    public void GoToMenu()
    {
        menu.SetActive(true);
        shop.SetActive(false);
    }
}
