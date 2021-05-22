using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;


        if (transform.position.x < -4.0f || transform.position.x > 4.0f)
        {
            speed = -speed;
            transform.position += Vector3.down * 0.2f;

        }

    }
}
