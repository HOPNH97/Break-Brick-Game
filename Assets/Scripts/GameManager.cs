using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void EndGame()
    {
        //Time.timeScale = 0;
        //StartCoroutine("GameOver");
        SceneManager.LoadScene(0);
    }
    private IEnumerable GameOver()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
