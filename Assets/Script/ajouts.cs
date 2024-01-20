using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ajouts : MonoBehaviour
{

    public int besoins = 10;
    public int ajout = 0;
    public int facteurDeBesoin = 10;
    public int facteurDAjout = 1;
    public int attente1 = 2;
    public Base bases;

    private void Start()
    {
        StartCoroutine(MyCoroutine());
    }


    public void clic()
    {
       
        if (bases.ValeursMonetaire >= besoins)
        {
            bases.ValeursMonetaire -= besoins;
            besoins += facteurDeBesoin;
            ajout += facteurDAjout;
        }
    }

    public IEnumerator MyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(attente1);
            bases.ValeursMonetaire += ajout;
        }
    }


   
}
