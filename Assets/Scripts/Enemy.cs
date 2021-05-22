using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    private int scoreN;
    public GameController gameC;
    public EnemyMover enemyM;
    public Player player;
    public Text score;
    public Text hiscore;
    public GameObject ExplosionParitcles;

    private Animator enemyAnimator;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    void Update()
    {


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "bullet")
        {
            scoreN = int.Parse(score.text);
            Destroy(gameObject);
            GameObject blast = Instantiate(ExplosionParitcles, gameObject.transform.position, Quaternion.identity);
            blast.GetComponent<ParticleSystem>().Play();


            if (this.tag == "enemy 10")
            {
                scoreN += 10;
            }
            if (this.tag == "enemy 20")
            {
                scoreN += 20;
            }
            if (this.tag == "enemy 30")
            {
                scoreN += 30;
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
        gameC.enemyNum--;
        Debug.Log(gameC.enemyNum);

        if (gameC.enemyNum == 14)
        {
            enemyM.speed = enemyM.speed * 2;
        }
        if (gameC.enemyNum == 7)
        {
            enemyM.speed = enemyM.speed * 2;
        }
        if (gameC.enemyNum == 3)
        {
            enemyM.speed = enemyM.speed * 2;
        }
        if (gameC.enemyNum == 2)
        {
            enemyM.speed = enemyM.speed * 2;
        }
        if (gameC.enemyNum == 1)
        {
            enemyM.speed = enemyM.speed * 2;
        }
        if (gameC.enemyNum == 0 )
        {
            hiscore.text = score.text;
            SceneManager.LoadScene(sceneName: "GameOver");
        }


    }
}
