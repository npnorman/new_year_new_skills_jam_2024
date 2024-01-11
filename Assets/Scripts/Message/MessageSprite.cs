using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSprite : MonoBehaviour
{
    public Sprite message;
    GameObject gameManager;
    SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        gameManager = GameObject.FindGameObjectWithTag("gameManager");
        sp.sprite = message;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //send to gameManager
        gameManager.GetComponent<Stats>().CollectMessage(message);
        //delete object
        Destroy(this.gameObject);
    }
}
