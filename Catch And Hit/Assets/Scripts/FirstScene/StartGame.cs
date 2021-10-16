using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject DarkPanel;
    public void StartGaming()
    {
        DarkPanel.SetActive(true);
        StartCoroutine(Go());
    }

    IEnumerator Go()
    {
        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadScene(1);
    }
}
