using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tentacleRandomMove : MonoBehaviour
{
    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;

    private void Start()
    {
        transform.position = new Vector2(Random.Range(-924f, 912f), Random.Range(-477f, 464f));
    }
    void Update()
    {

    }

    void FixedUpdate()
    {
       
    }
}
