using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSprite : MonoBehaviour
{
    public Sprite message;
    public GameObject gameManager;
    SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        sp.sprite = message;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //send to gameManager
        gameManager.GetComponent<stats>().CollectMessage(message);
        //delete object
        Destroy(this.gameObject);
    }
}
