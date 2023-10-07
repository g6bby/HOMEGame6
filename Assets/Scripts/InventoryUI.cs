using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI bubbleText;

    void Start()
    {
        bubbleText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateBubbleText(PlayerInventory playerInventory)
    {
        bubbleText.text = playerInventory.NumberOfBubbles.ToString();

        if (bubbleText.text == "35")
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene("EndScreen");
        }
    }
}
