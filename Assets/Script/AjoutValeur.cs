using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutValeur : MonoBehaviour
{

   
    public Base bases;
    public int ajoutsBases = 1; 

    public void clic()
    {
        bases.ValeursMonetaire += ajoutsBases;
    }
}