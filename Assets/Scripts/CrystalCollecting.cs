using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

public class CrystalCollecting : MonoBehaviour
{
    public AudioClip[] CrystalCollectArray;
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
        
        clipIndex = Random.Range(0, CrystalCollectArray.Length);
        effectSource.pitch = pitch;
        effectSource.PlayOneShot(CrystalCollectArray[clipIndex],vol);
        
        
        Debug.Log("the volume is supposed to be: " + vol);
        Debug.Log("the pitch is supposed to be: " + pitch);
    }

    
    void PlaySequence()
    {
        //play in sequence
        if (clipIndex == CrystalCollectArray.Length)
        {
            clipIndex = 0;
        }
        //else
        //{
        //}
        effectSource.PlayOneShot(CrystalCollectArray[clipIndex]);
        clipIndex++;
    }
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("We hit something");
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
