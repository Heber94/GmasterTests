
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class Offline6Museos : MonoBehaviour
{
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_InteractiveItem.OnClick += HandleClick;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_InteractiveItem.OnClick -= HandleClick;

    }


    //Metodo para cambiar a la escena 1 al ser pulsado.
    public void HandleClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(6);
    }



    public void HandleOver()
    {
        gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    public void HandleOut()
    {
        gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

}

