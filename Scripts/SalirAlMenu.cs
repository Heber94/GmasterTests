using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;


public class SalirAlMenu : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem m_InteractiveItem;


    private void OnEnable()
    {
        m_InteractiveItem.OnClick += HandleClick;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnClick -= HandleClick;
    }


    //Metodo para salir al menu.
    public void HandleClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }


}
