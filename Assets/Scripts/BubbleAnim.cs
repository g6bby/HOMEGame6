using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleAnim : MonoBehaviour
{
    public Animator animator;
    public GameObject player;
    public GameObject bubble;
    public AudioSource bubbleAudio;

    private void Start()
    {
        animator.gameObject.GetComponent<Animator>().enabled = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        bubbleAudio.Play();
        animator.gameObject.GetComponent<Animator>().enabled = true;

        animDelay();


    }

   public IEnumerator animDelay()
    {
        yield return new WaitForSeconds(0.001f);
        gameObject.SetActive(false);

    }

}
