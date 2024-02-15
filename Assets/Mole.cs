using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class Mole : MonoBehaviour
{
    
    Score score;
    MoleSpawner spawner;
    int scoreAmount = 1;


    // Start is called before the first frame update
    void Start()
    {
        score = FindAnyObjectByType<Score>();
        spawner = FindAnyObjectByType<MoleSpawner>();

    }

    // Update is called once per frame
    void Update()
    {
        if(score.getPoints() < 10)
        {
            Destroy(gameObject, 3);
        }
        else if (score.getPoints() >= 10 && score.getPoints() < 20)
        {
            Destroy(gameObject, 2);
        }
        else if (score.getPoints() >= 20)
        {
            Destroy(gameObject, 1); 
        }

    }

    public void sendPoints()
    {
        score.Points(scoreAmount);
        Destroy(gameObject);
    }

    public void setSpawnTime()
    {
        if (score.getPoints() < 60)
        {
            if (score.getPoints() % 5 == 0)
            {
                spawner.lowerTimeBetweenSpawns();
            }
        }
    }
}
