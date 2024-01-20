using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class augmenteValeurs : MonoBehaviour
{
    public AjoutValeur ajoutValeurs;
    public Base bases;
    public Button buton;
    public int besoins;
    public int facteur = 0;
    public int ajouts;
    public void clic()
    {
        if (bases.ValeursMonetaire >= besoins)
        {
            facteur += ajouts;
            bases.ValeursMonetaire -= besoins;
            buton.interactable = false;

        }



    }
    private void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    public IEnumerator MyCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            bases.ValeursMonetaire += facteur;
        }
    }
}
