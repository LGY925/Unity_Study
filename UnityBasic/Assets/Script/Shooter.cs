using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform muzzle;

    [Range(10, 50)]
    [SerializeField] float bulletSpeed;

    public void Fire()
    {
        GameObject instance= Instantiate(bullet, muzzle);

        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzle.forward * bulletSpeed;
        Destroy(instance,3);
    }

}
