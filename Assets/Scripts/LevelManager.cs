using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private int nextSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score;
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetLevel()
    {
        scoreText.text = "Score: 0";
        StartCoroutine(WaitTillRestart());
    }

    public void AddFood(int numberOfFood)
    {
        score += numberOfFood;
        scoreText.text = "Score: " + score;
        if (score == 10 * SceneManager.GetActiveScene().buildIndex)
        {
            StartCoroutine(ChangeScene());
        }
    }

    public void AddObj(int numberOfObj)
    {
        score += numberOfObj;
        scoreText.text = "Score: " + score;
        if (score == 10 * SceneManager.GetActiveScene().buildIndex)
        {
            StartCoroutine(ChangeScene());
        }
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(nextSceneToLoad);
    }

    IEnumerator WaitTillRestart()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(0);
    }
}
