using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{

    public GameObject Plane_shop_upgrade;
    public Transform target;    
    public void clic()
    {
        Plane_shop_upgrade.transform.position = new Vector3(Screen.width/2, Screen.height/ 2, Plane_shop_upgrade.transform.position.z);



    }
}
