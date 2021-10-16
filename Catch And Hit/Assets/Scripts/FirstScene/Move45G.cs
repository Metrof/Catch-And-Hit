using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move45G : MonoBehaviour
{
    [SerializeField] private GameObject endPoint;
    [SerializeField] private GameObject startPoint;
    Vector3 diraction;
    Vector3 start;
    private void Awake()
    {
        diraction = endPoint.transform.position;
        start = startPoint.transform.position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, diraction, 1f * Time.deltaTime);
        if (transform.position == diraction)
        {
            transform.position = start;
        }
    }
}
