using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class BombBoy : MonoBehaviour
{
    public AudioClip[] BombBoyArray;
    public AudioSource effectSource;
    private int clipIndex = 0;

    public float lowVolRange = 0.7f;
    public float highVolRange = 1.2f;

    public float lowPitchRange = 0.7f;
    public float highPitchRange = 1.2f;

    void Start()
    {
        effectSource = GetComponent<AudioSource>();
    }

    void PlayRandom()
    {
        float vol = Random.Range(lowVolRange, highVolRange);
        float pitch = Random.Range(lowPitchRange, highPitchRange);

        clipIndex = Random.Range(0, BombBoyArray.Length);
        effectSource.pitch = pitch;
        effectSource.PlayOneShot(BombBoyArray[clipIndex], vol);


        Debug.Log("the volume is supposed to be: " + vol);
        Debug.Log("the pitch is supposed to be: " + pitch);
    }


    void PlaySequence()
    {
        //play in sequence
        if (clipIndex == BombBoyArray.Length)
        {
            clipIndex = 0;
        }
        //else
        //{
        //}
        effectSource.PlayOneShot(BombBoyArray[clipIndex]);
        clipIndex++;
    }
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("hit something");
            //source.PlayOneShot(effectSource);
            //PlaySequence();
            PlayRandom();
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}