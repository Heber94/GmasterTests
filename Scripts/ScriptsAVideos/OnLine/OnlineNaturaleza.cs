using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;

public class OnlineNaturaleza : MonoBehaviour
{
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;


    private void OnEnable()
    {
        m_InteractiveItem.OnClick += HandleClick;
    }


    private void OnDisable()
    {
        m_InteractiveItem.OnClick -= HandleClick;
    }


    //Metodo para cambiar a la escena 1 al ser pulsado.
    public void HandleClick()
    {
        Application.OpenURL("https://turismoinclusivo.grupoaspanias.com/index.php?id=27");
    }
    
}
