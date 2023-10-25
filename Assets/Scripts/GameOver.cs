using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TextMeshProUGUI timeSurvived;
    bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            if (Input.GetKeyUp(KeyCode.Space)) {
                SceneManager.LoadScene(0);
                    }
        }
    }
    public void OnGameOver()
    {           
        gameOverScreen.SetActive(true);
        timeSurvived.text=Time.timeSinceLevelLoad.ToString();
        gameOver = true;

    }
}
