using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public static bool Res;
    public virtual void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Res = true;
    }
}
