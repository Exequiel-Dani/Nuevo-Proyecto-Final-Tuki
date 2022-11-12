using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaYSonidos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.instance.Play("Muerte");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
