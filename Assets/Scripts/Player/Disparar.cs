using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public float BalaVelocidad;

    [SerializeField] private AudioClip sonidoDisparo;
    AudioSource audioDisp;

void Start()
    {
        audioDisp=GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            audioDisp.PlayOneShot(sonidoDisparo);
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation);
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * BalaVelocidad);
            Destroy(BalaTemporal, 5f);
        }
    }
}
