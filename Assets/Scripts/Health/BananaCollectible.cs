using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaCollectible : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SoundManager.instance.PlaySound(pickupSound);
            collision.GetComponent<Health>().AddBanana(1);
            gameObject.SetActive(false);
        }
    }

}
