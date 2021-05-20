using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootingOffset;

    public float fireRate = 0.999f;

    // Update is called once per frame
    void Update()
    {
        if (Random.value  > fireRate)
        {
            GameObject enemyShot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);

            Destroy(enemyShot, 3f);
        }

    }

}
