using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrase : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collison)
    {
        if (collison.CompareTag("Player"))
        {
           Score.instance.ScoreUpdate();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
