using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private float SpeedCannon = 6f;
    private float amp = 30;
    private float velocityMult = 7f;
    private float MinrateOfFire = 4f;
    private float MaxrateOfFire = 8f;
    private float rateOfFire;

    private GameObject bullet;
    private Rigidbody2D bulletRigidbody;
    public GameObject prefabBullet;
    public GameObject LaunchPoint;
    public GameObject ShotPoint;

    static public bool StopInvoke;
    void Start()
    {
        StopInvoke = true;
        rateOfFire = Random.Range(MinrateOfFire, MaxrateOfFire);
        InvokeRepeating("Shot", rateOfFire, rateOfFire);
    }
    private void Shot()
    {
        if (StopInvoke)
        {
            rateOfFire = Random.Range(MinrateOfFire, MaxrateOfFire);
            bullet = Instantiate(prefabBullet);
            bulletRigidbody = bullet.GetComponent<Rigidbody2D>();
            bullet.transform.position = ShotPoint.transform.position;
            Vector3 CannonDelta = ShotPoint.transform.position - LaunchPoint.transform.position;
            bulletRigidbody.velocity = CannonDelta * velocityMult;
            bullet = null;
            return;
        }
        CancelInvoke("Shot");
    }

    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Sin(Time.time * SpeedCannon) * amp));
    }

    
}
