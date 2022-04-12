
using UnityEngine;

public class Gun : MonoBehaviour
{

    public float range = 100f;
    public ParticleSystem muzzleFlash;

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
    }
}
