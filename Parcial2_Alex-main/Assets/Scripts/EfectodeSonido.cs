using UnityEngine;
using System.Collections.Generic;
using UnityEngine;


public class EfectodeSonido : MonoBehaviour
{
   private AudioSource audioSource;

   [SerializeField]
   private AudioClip correct1;
   [SerializeField]
   private AudioClip correct2;
   private void Start()
   {
    audioSource = GetComponent<AudioSource>();
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
    if (other.CompareTag("Player"))
    {
        audioSource.PlayOneShot(correct2);
    }
   }

}
