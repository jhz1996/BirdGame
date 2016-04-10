using UnityEngine;
using System.Collections;

[System.Serializable]

public class transform : MonoBehaviour
{
    
    public float speed;
    private float nextFire;
    public GameObject mycam;
    //private Vector3 camVector;

    

    //void Start()
    //{
    //    camVector = mycam.transform.up;
    //}

    void Update()
    {
        transform.Translate(transform.forward * speed * Time.deltaTime);
    }


}