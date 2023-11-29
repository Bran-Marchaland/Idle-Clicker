using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Base : MonoBehaviour
{
    public TextMeshProUGUI VM;
    public int ValeursMonetaire = 0;
    public int autoM = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        VM.text = "" + ValeursMonetaire;

    }
}

    
