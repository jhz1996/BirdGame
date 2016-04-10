using UnityEngine;
using System.Collections;

public class camFire : MonoBehaviour
{
    //public GameObject PlanetCamPrefab = Resources.Load("PlanetCam") as GameObject;
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //       var newB = Instantiate(Resources.Load("bullet"));
    //    }
    //}


    public Transform bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //you don't have to instantiate at the transform's positio nand rotation, swap these for what suits your needs
            var go = Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
