using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class MostrarCarteles : MonoBehaviour
{
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;
    [SerializeField]
    GameObject[] carteles;


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
    }

    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
    }

    public void HandleOver()
    {
        foreach (GameObject cartel in carteles)
        {
            cartel.SetActive(true);
        }
    }
    public void HandleOut()
    {
        foreach (GameObject cartel in carteles)
        {
            cartel.SetActive(false);
        }
    }
}
