using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombMusic : MonoBehaviour
{
    Audio AudioMusic;
    // Start is called before the first frame update
    void Start()
    {
        AudioMusic = GameObject.FindGameObjectWithTag("audio").GetComponent<Audio>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player") )
        {
            AudioMusic.playmusic(AudioMusic.BombClip);

        }
    }
}
