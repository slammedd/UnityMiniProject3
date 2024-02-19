using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private PlayerController player;
    private bool menuOnScreen;

    public TextMeshProUGUI finalScoreText;
    public GameObject restartButton;
    public GameObject quitButton;
    public int finalScore;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(player == null && menuOnScreen == false)
        {
            menuOnScreen = true;
            finalScoreText.text = ("Your score was " + finalScore + ".");
            finalScoreText.gameObject.SetActive(true);
            restartButton.SetActive(true);
            quitButton.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0;
        }
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
