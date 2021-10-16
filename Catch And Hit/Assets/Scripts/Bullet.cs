using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject explousion;
    private int Charje;
    const float Abyss = -5f;
    public static int score;
    new SpriteRenderer renderer;

    public Sprite blueBall;
    public Sprite purpleBall;
    public Sprite redBall;

    private void Start()
    {
        Charje = 0;
        renderer = GetComponent<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.GetComponent<platform>())
        {
            Charje++;
            switch (Charje)
            {
                case 1:
                    renderer.sprite = blueBall;
                    break;
                case 2:
                    renderer.sprite = purpleBall;
                    break;
                case 3:
                    renderer.sprite = redBall;
                    break;
            }
            if (Charje == 3)
            {
                ScoreScript.MyScore += 100;
                Invoke("Complete", 0.8f);
            }
        }
    }
    private void Update()
    {
        if (transform.position.y < Abyss)
        {
            Destroy(gameObject);
            if (Charje != 3)
            {
                EndGame.Lives--;
            }
        }
    }
    private void Complete()
    {
        Explousion();
        Destroy(gameObject);
    }
    private void Explousion()
    {
        GameObject pointToExplo = Instantiate(explousion);
        pointToExplo.transform.position = transform.position;
        Destroy(pointToExplo, 0.35f);
    }
}
