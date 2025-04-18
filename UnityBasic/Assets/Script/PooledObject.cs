using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObject : MonoBehaviour
{
    public ObjectPool returnPool;
    [SerializeField] float returnTime;
    private float timer;

    [Header("Propertis")]
    [SerializeField] GameObject hitEffetPrefap;

   

    private void OnEnable()
    {
        timer = returnTime;
    }
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            ReturnPool();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ReturnPool();
        Instantiate(hitEffetPrefap,transform.position,transform.rotation);
    }
    public void ReturnPool()
    {
        if (returnPool == null)
        {
            Destroy(gameObject);
        }
        else
        {
            returnPool.ReturnPool(this);
        }
    }
    
}
