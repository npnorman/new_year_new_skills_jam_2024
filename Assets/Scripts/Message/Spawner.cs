using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject messagePrefab;
    public MessageInfo[] messages;
    Vector3 spawnArea;

    // Start is called before the first frame update
    void Start()
    {
        spawnArea = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        messagePrefab.GetComponent<SpriteRenderer>().sprite = messages[0].sprite;
        Instantiate(messagePrefab, spawnArea, transform.rotation);
    }
}
