using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject messagePrefab;
    public MessageInfo[] messages;
    int index = 0;
    public GameObject[] collection;
    Vector3 spawnArea;

    // Start is called before the first frame update
    void Start()
    {
        spawnArea = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Spawn();
    }

    public void Spawn()
    {
        if (messages.Length > index)
        {
            messagePrefab.GetComponent<SpriteRenderer>().sprite = messages[index].sprite;
            Instantiate(messagePrefab, spawnArea, transform.rotation);
            PickCollector();
        } else
        {
            //win condition
        }
    }

    public void PullMessage()
    {
        if (messages.Length > index)
        {
            //remove first item in list and shorten by 1
            index++;
        }
    }

    void PickCollector()
    {
        int selector = Random.Range(0, collection.Length);
        collection[selector].GetComponent<Collection>().isCorrectCollector = true;
        Debug.Log(selector);
    }
}
