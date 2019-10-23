using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class EmisorLuzCubos : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem m_InteractiveItem;
    [SerializeField] GameObject emisor;
//This file didn't have changes before.


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        emisor.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;

    }

    public void HandleOver()
    {
        emisor.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    public void HandleOut()
    {
        emisor.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }


}
