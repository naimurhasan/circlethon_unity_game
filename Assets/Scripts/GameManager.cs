using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1f;
    bool hasGameEnded = false;
    public GameObject completeLevelUI;

    public void CompleteGame(){
        Debug.Log("Game Comlete");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (hasGameEnded == false)
        {
            hasGameEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
