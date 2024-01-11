using UnityEngine;

[CreateAssetMenu(fileName = "MessageInfo", menuName = "ScriptableObjects/CreateMessage", order = 1)]
public class MessageInfo : ScriptableObject
{
    public string messageTitle;
    public Sprite sprite;
}
