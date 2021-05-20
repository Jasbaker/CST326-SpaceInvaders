using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Transform player;
    public float speed;
    public float maxBound, minBound;
    public GameObject bullet;

  public Transform shootingOffset;

    void Start()
    {
        player = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minBound && h < 0)
            h = 0;
        else if (player.position.x > maxBound && h > 0)
            h = 0;

        player.position += Vector3.right * h * speed;

        if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);

        Destroy(shot, 3f);

      }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
