using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    private int scoreN;
    public GameController gamec;
    public Text score;
    public Text hiscore;
    public GameObject ExplosionParitcles;

    public Transform enemyMover;
    public float speed;

    void Start()
    {
        enemyMover = GetComponent<Transform>();
    }

    void Update()
    {
        enemyMover.position += Vector3.right * speed * Time.deltaTime;
        if (transform.position.x < -8.0f || transform.position.x > 8.0f)
        {
            speed = -speed;
            enemyMover.position += Vector3.down * 0.5f;
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            scoreN = int.Parse(score.text);
            Destroy(gameObject);
            GameObject blast = Instantiate(ExplosionParitcles, gameObject.transform.position, Quaternion.identity);
            blast.GetComponent<ParticleSystem>().Play();

            if (this.name == "Enemy 10")
            {
                scoreN += 10;
            }
            if (this.name == "Enemy 20")
            {
                scoreN += 20;
            }
            if (this.name == "Enemy 30")
            {
                scoreN += 30;
            }
            if (this.name == "Enemy ?")
            {
                scoreN += 50;
            }
            if (scoreN >= 100 || scoreN < 1000)
            {
                score.text = ($"0{scoreN.ToString()}");
            }
            if (scoreN < 100)
            {
                score.text = ($"00{scoreN.ToString()}");
            }
            EnemyCount();

        }


    }
    
    private void EnemyCount()
    {
        gamec.enemyNum--;
        if (gamec.enemyNum == 0)
        {
            hiscore.text = score.text;
        }


    }
}
