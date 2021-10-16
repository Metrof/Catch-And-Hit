using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    private GameObject cannon;
    private GameObject Platform;
    private List<GameObject> bullets;

    public GameObject pointRestart;
    public GameObject pointStart;

    Vector3 PoiResPos;
    Vector3 poiStarPos;

    private static int lives = 3;
    private static LivesBar livesBar;
    public static int Lives
    {
        get { return lives; }
        set 
        { 
            lives = value;
            livesBar.Refresh();
        }
    }
    private void Awake()
    {
        livesBar = FindObjectOfType<LivesBar>();
    }
    private void Start()
    {
        cannon = GameObject.Find("Canon");
        Platform = GameObject.Find("Platform");
        bullets = new List<GameObject>();

        PoiResPos = pointRestart.transform.position;
        poiStarPos = pointStart.transform.position;
    }
    private void Update()
    {
        if (lives == 0)
        {
            Cannon.StopInvoke = false;
            SoundManager.Lose = true;
            if (bullets != null)
            {
                bullets.AddRange(GameObject.FindGameObjectsWithTag("Bullet"));
                foreach (GameObject item in bullets)
                {
                    Destroy(item);
                }
                bullets = null;
            }
            cannon.GetComponent<Cannon>().enabled = false;
            Platform.GetComponent<platform>().enabled = false;
            transform.position = Vector3.MoveTowards(transform.position, PoiResPos, 1000f * Time.deltaTime);
            if (RestartGame.Res)
            {
                Cannon.StopInvoke = true;
                cannon.GetComponent<Cannon>().enabled = true;
                Platform.GetComponent<platform>().enabled = true;
                lives = 3;
                ScoreScript.MyScore = 0;
                transform.position = poiStarPos;
                RestartGame.Res = false;
            }
        }
    }
}
