using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class augmenteClick : MonoBehaviour
{
    public AjoutValeur ajoutValeurs;
    public Base bases;
    public Button buton;
    public int besoins = 25;
    public int facteur;
    public void clic()
    {
        if (bases.ValeursMonetaire >= besoins)
        {
            ajoutValeurs.ajoutsBases += facteur;
            bases.ValeursMonetaire -= besoins;
            buton.interactable = false;
        }
    }
}