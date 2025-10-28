using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ActiveConfig(GameObject go)
    {
        go.SetActive(true);
    }


    public void DisableConfig(GameObject go)
    {
        go.SetActive(false);
    }

    public void ActivePause(GameObject go)
    {
        Time.timeScale = 0;
        go.SetActive(true);
    }

    public void DisablePause(GameObject go) {
        Time.timeScale = 1;
        go.SetActive(false);
    }

    public void Gotohome(GameObject go) {
        go.SetActive(true);
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}
