using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //StartGame loads the Samplescene, where the fighting happens and EndGame() goes back to the start menu
    static public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    //EndGame() is called in Toilet.cs, when a mutant dies
    static public void EndGame()
    {
        SceneManager.LoadScene("LoadingScene");
    }
}
