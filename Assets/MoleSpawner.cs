using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoleSpawner : MonoBehaviour
{
    [SerializeField] GameObject molePrefab;
    [SerializeField] float timeBetweenSpawns;
    float elapsed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        

        if (elapsed >= timeBetweenSpawns)
            {
                spawner();
                elapsed = 0;
            }


    }

    private void spawner()
    {
        GameObject g = Instantiate(molePrefab, transform);
        int xPos = Random.Range(10, 1200);
        int yPos = Random.Range(15, 650);
        g.transform.position = new Vector3(xPos, yPos, 0);
    }

   public void lowerTimeBetweenSpawns()
    {
        timeBetweenSpawns -= 0.05f;
    }
}
