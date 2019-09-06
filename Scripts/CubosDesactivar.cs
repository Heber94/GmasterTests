using System.Collections;
using System.Collections.Generic;
using VRStandardAssets.Utils;
using UnityEngine;

public class CubosDesactivar : MonoBehaviour
{
    [SerializeField]
    private VRInteractiveItem m_InteractiveItem;

    //Array donde estarán los cubos a los que se les activarán las propiedades.
    [SerializeField] GameObject[] cubosSeleccion;


    void OnEnable()
    {
        m_InteractiveItem.OnClick += desactivar;
    }

    void OnDisable()
    {
        m_InteractiveItem.OnClick -= desactivar;
    }

    void desactivar()//A conflcit here
    {

        foreach (GameObject cubo in cubosSeleccion)
        {
            if (cubo != (this.gameObject))
            {
                cubo.SetActive(false);//This was deleted in other changeset
            }
        }
        this.gameObject.SetActive(false);

    }
}

