using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMusic : MonoBehaviour
{
    private Audio Audiomusic;
    private void Awake()
    {
        Audiomusic = GameObject.FindGameObjectWithTag("audio").GetComponent<Audio>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Audiomusic.playmusic(Audiomusic.FireClip);
            Destroy(gameObject);
        }
    }

}
