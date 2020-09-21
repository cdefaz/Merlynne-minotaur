using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void NextLevelButton(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

}