using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticlelCollectible : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlaySound(pickupSound);
            collision.GetComponent<Health>().starParticlel();
            gameObject.SetActive(false);
        }
    }
}
