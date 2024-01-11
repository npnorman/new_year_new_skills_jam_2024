using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    //all relevant information that needs to be tracked
    public int playerHealth = 100;
    public int score = 0;
    public bool hasMessage = false;
    public GameObject imagePlaceholder;

    private void Start()
    {
        imagePlaceholder.SetActive(false);
    }

    public void CollectMessage(Sprite sprite)
    {
        //set that player has message to true
        hasMessage = true;
        //show UI
        imagePlaceholder.SetActive(true);
        //put the message on UI
        imagePlaceholder.GetComponent<Image>().sprite = sprite;

    }

    public void RemoveMessage()
    {
        //set that player has message to show
        hasMessage = false;
        //hide UI
        imagePlaceholder.SetActive(false);
    }

}
