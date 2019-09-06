using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class EntrarCentro : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem m_InteractiveItem;
    [SerializeField] GameObject gameObject;


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_InteractiveItem.OnClick += HandleClick;
        gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
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
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    
    public void HandleOver() {
        gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    public void HandleOut() {
        gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }

}
