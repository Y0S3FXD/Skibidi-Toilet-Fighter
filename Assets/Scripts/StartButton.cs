using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    static public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    static public void EndGame()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
