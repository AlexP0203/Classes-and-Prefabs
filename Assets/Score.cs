using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;

public class Score : MonoBehaviour
{
    TMP_Text heading;
    int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        heading = FindAnyObjectByType<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Points(int pts)
    {
        points += pts;
        heading.text = points.ToString();
    }

    public int getPoints()
    {
        return points;
    }
}

