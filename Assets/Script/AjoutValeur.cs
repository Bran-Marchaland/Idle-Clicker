using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutValeur : MonoBehaviour
{

   
    public Base bases;

    public void clic()
    {
        bases.ValeursMonetaire += 1;
    }
}