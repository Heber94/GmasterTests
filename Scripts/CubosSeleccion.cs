using System.Collections;
using System.Collections.Generic;
using VRStandardAssets.Utils;
using UnityEngine;

public class CubosSeleccion : MonoBehaviour
{
    [SerializeField] private VRInteractiveItem m_InteractiveItem;

    //Array donde estarán los cubos a los que se les activarán las propiedades.
    [SerializeField] GameObject[] cubosSeleccion;
    [SerializeField] GameObject[] cubosGeneral;
    [SerializeField] GameObject nombreCat;





    void OnEnable() {
        m_InteractiveItem.OnClick += activar;
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;


    }

    void OnDisable()
    {
        m_InteractiveItem.OnClick -= activar;
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
    }

    void activar() {
        foreach (GameObject cuboGen in cubosGeneral) {
            cuboGen.SetActive(false); 
        }

        foreach (GameObject cubo in cubosSeleccion) {
            cubo.SetActive(true);
        }

    }
    public void HandleOver()
    {
        nombreCat.SetActive(true);
    }
    public void HandleOut()
    {
        nombreCat.SetActive(false);
    }
}
