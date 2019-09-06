
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class MoverA2 : MonoBehaviour
{
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;


    private void OnEnable()
    {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
        m_InteractiveItem.OnClick += HandleClick;
        m_InteractiveItem.OnDoubleClick += HandleDoubleClick;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
        m_InteractiveItem.OnClick -= HandleClick;
        m_InteractiveItem.OnDoubleClick -= HandleDoubleClick;
    }


    //Metodo para cambiar a la escena 1 al ser pulsado.
    public void HandleClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }



    public void HandleOver()
    {
        gameObject.GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
    public void HandleOut()
    {
        gameObject.GetComponent<Renderer>().material.DisableKeyword("_EMISSION");
    }
    //Por ahora estos métodos no hacena nada, pero se dejan para indicar como añadir nuevas funcionalidades.
    public void HandleDoubleClick() { }
}
