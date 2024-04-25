using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] private GameObject gameOverCanvas;
    [SerializeField] private GameObject startGameCanvas;
    [SerializeField] private GameObject scoreboardCanvas;
    [SerializeField] private GameObject player;
    private Vector3 startPos;
    private bool gameEnded = false;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        Time.timeScale = 0f;
    }
    private void Update()
    {
        if (!gameEnded)
        {
#if UNITY_STANDALONE || UNITY_STANDALONE_WIN || UNITY_EDITOR
            if (Input.GetMouseButtonDown(0))
            {
                StartGame();
            }
#elif UNITY_ANDROID
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            StartGame();
        }
#endif
        }
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0f;
        gameEnded = true;
    }
    
    public void StartGame()
    {
        startGameCanvas.SetActive(false);
        scoreboardCanvas.SetActive(true);
        Time.timeScale = 1f;
    }

    /*public void RestartGame()
    {
        player.transform.position = startPos;
        ScoreManager.instance.
    }*/

    public void MainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
