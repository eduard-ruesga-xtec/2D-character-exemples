using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GameManager._ins.IncreaseCoin();
            audio.Play();
            Invoke("OnfinishClip", audio.clip.length);
        }
    }
    void OnfinishClip()
    {
        Destroy(this.gameObject);
    }
}
