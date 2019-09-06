using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
//Changes for demo
//Conclict here
public class MostrarInformacion : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem m_InteractiveItem;
    [SerializeField] private GameObject UI;


    private void OnEnable()
    {
        m_InteractiveItem.OnClick += HandleClick;
		m_InteractiveItem.OnDoubleClick += HandleDoubleClick;

    }
    //Doesn't have a conflict

        private void OnDisable()
        {
            m_InteractiveItem.OnClick -= HandleClick;
        }
//Doesn't have a conflict

    //Metodo para cambiar a la escena 1 al ser pulsado.
    public void HandleClick()
    {
        if (UI.active)
        {
			Aqui da igual
            UI.SetActive(false);
        }
        else if (!UI.active) {
            UI.SetActive(true);
        }

    }
	    public void HandleDoubleClick()
    {
        if (UI.active)
        {
            UI.SetActive(false);
        }
        else if (!UI.active) {
            UI.SetActive(true);
        }

    }

}

