using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int NumberOfBubbles {get; private set;}

    public UnityEvent<PlayerInventory> OnBubbleCollected;

    public void BubbleCollected()
    {
        NumberOfBubbles++;
        OnBubbleCollected.Invoke(this);
    }

}
