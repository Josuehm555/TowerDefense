using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menus : MonoBehaviour
{
    private int level = 4;
    private int actionPauRes = 0;
    private int control = 3;

    public TextMeshProUGUI TextPro;

    public void Game() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        Debug.Log(level);
    }

    public void Quit() {
        Debug.Log("Salir");
        Application.Quit();
    }

    public void Reload() {
        SceneManager.LoadScene(0);
    }

    public void NextLevel() {
        level++;
        SceneManager.LoadScene(level);
        Debug.Log(level);
    }

    public void Controls() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause() {
        if (actionPauRes == 0 ) {
            Time.timeScale = 0f;
            actionPauRes++;
            TextPro.text = "Resume";
        }
        else {
            Time.timeScale = 1f;
            actionPauRes = 0;
            TextPro.text = "Pause";
        }
        
    }
}
