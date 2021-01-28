using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    Shooter shooter;
    private void OnEnable()
    {
        shooter = GameObject.FindWithTag("Shooter").GetComponent<Shooter>();
        Invoke("GetPolled", 2);
    }
    public void GetPolled()
    {
        Debug.Log("GetPooled");
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;//zero speed
        shooter.bulletPool.Add(gameObject);//added the bullet pool
        gameObject.SetActive(false);
        

    }

}
