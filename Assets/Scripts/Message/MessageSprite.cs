using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSprite : MonoBehaviour
{
    public Sprite message;
    SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
        sp.sprite = message;
    }
}
