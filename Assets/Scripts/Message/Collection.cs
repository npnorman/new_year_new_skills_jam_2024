using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{
    public bool isCorrectCollector = false;
    GameObject gameManager;
    GameObject spawner;
    Stats stats;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
        spawner = GameObject.FindGameObjectWithTag("spawner");
        stats = gameManager.GetComponent<Stats>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isCorrectCollector)
        {
            //verified
            //add to score
            stats.score++;
            //remove one from message spawner
            spawner.GetComponent<Spawner>().PullMessage();
        } else {
            //do nothing
        }

        //spawn next message
        spawner.GetComponent<Spawner>().Spawn();
        //has message is false
        //remove message from UI
        stats.RemoveMessage();
    }
}
