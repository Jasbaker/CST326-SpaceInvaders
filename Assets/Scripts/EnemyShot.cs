using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    public GameObject bullet;
    public Transform shootingOffset;
    public Enemy enemy;

    private Animator enemyAnimator;

    public float fireRate = 0.999f;

    void Start()
    {
        enemyAnimator = enemy.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Random.value  > fireRate)
        {
            GameObject enemyShot = Instantiate(bullet, shootingOffset.position, Quaternion.identity);
            enemyAnimator.SetTrigger("shoot");

            Destroy(enemyShot, 3f);
        }

    }

}
