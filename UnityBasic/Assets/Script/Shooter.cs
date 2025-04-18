using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzle;
    [SerializeField] ObjectPool bulletPool;

    [Range(0, 50)]
    [SerializeField] float bulletSpeed;
    [SerializeField] float repeatTime;
    private Coroutine fireCoroutine;

    private void Fire()
    {
        PooledObject instance = bulletPool.GetPool(muzzle.position,muzzle.rotation);

        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzle.forward * bulletSpeed;
    }

    private void Fire(float bulletSpeed)
    {
        PooledObject instance = bulletPool.GetPool(muzzle.position, muzzle.rotation);

        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzle.forward * bulletSpeed;
    }

    IEnumerator FireRoutine()
    {
        WaitForSeconds delay = new WaitForSeconds(repeatTime);
        while (true)
        {
            Fire();
            yield return delay;
        }
    }


    //IEnumerator ChargeRoutin()
    //{
    //    float timer = 0;
    //    while (true)
    //    {
    //        timer += Time.deltaTime * 10;
    //        yield return null;
    //        if (Input.GetKeyUp(KeyCode.Space))
    //            break;
    //    }
    //    // �ּ� : 10 / �ִ� 100
    //    float bulletSpeed = Mathf.Clamp(timer, 10f, 100f);
    //    Fire(bulletSpeed);
    //
    //    fireCoroutine = null;
    //}

    public void FireActing()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (fireCoroutine == null)
            {
                fireCoroutine = StartCoroutine(FireRoutine());
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (fireCoroutine != null)
            {
                StopCoroutine(fireCoroutine);
                fireCoroutine = null;
            }
        }
        //if (Input.GetKeyDown(KeyCode.Space) && fireCoroutine == null)
        //{
        //    fireCoroutine = StartCoroutine(ChargeRoutin());
        //}
    }

}
