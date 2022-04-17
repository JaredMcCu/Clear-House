
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float range = 100f;
    public ParticleSystem muzzleFlash;
    public AudioSource gunShot;

    void start()
    {
        gunShot = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot ()
    {
        muzzleFlash.Play();
        gunShot.Play();
    }
}
