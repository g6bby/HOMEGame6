using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndChickenDialogue : MonoBehaviour
{
    public GameObject canvasObj;

    public Image fadeImage; 
    public float fadeSpeed = 1.0f; 
    private bool isFading = false;

    void Start()
    {

        fadeImage.color = Color.clear; 
        canvasObj.SetActive(false);
        fadeImage.enabled = false;

    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canvasObj.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    public void FinishDialogue()
    {

        canvasObj.SetActive(true);
        fadeImage.enabled = true;
        StartCoroutine(FadeToBlack());

    }

    IEnumerator FadeToBlack()
    {
        //yield return new WaitForSeconds(3.0f);


        isFading = true;

        Color currentColor = fadeImage.color;
        Color targetColor = Color.black;

        float elapsedTime = 0;

        while (elapsedTime < 1.0f / fadeSpeed)
        {
            fadeImage.color = Color.Lerp(currentColor, targetColor, elapsedTime * fadeSpeed);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        fadeImage.color = targetColor;

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("Start");


        isFading = false;
    }
}
