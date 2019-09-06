using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
public class APaginaBullying : MonoBehaviour
{
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;
    [SerializeField] GameObject cartel;
    //[SerializeField] GameObject emisor;


//Comentario para el test
//Otros
//Cambios

    private void OnEnable()
    {
        m_InteractiveItem.OnClick += HandleClick;
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        //emisor.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnClick -= HandleClick;
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
    }

    //Metodo para cambiar a la escena 1 al ser pulsado.
    public void HandleClick()
    {
        Application.OpenURL("https://contraelacosoescolar.es/");
    }

    public void HandleOver()
    {
        //emisor.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
        cartel.SetActive(true);
    }
    public void HandleOut()
    {
        cartel.SetActive(false);
        //emisor.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");

    }

}
