using System;
using UnityEngine;
using VRStandardAssets.Utils;

/*
 * Clase para la gestión del movimiento mediante teletransporte.
 * @author Héber Saiz.
 */

public class TeleportManager : MonoBehaviour
{
    public static event Action<Transform> DoTeleport; //Evento para lanzar el teletransporte.
    [SerializeField] VRInteractiveItem[] teleportLocations; //Array para la creación de posibles objetivos de teletransporte.
    [SerializeField] Transform reticleTransform; //Variable con el destino.


    // Se anaden las posibles posiciones a teleportarse.
    void OnEnable(){
        foreach (VRInteractiveItem location in teleportLocations){
            location.OnClick += Teleport;
        }
    }

    // Se eliminan las posiciones para evitar problemas de memoria.
    void OnDisable(){
        foreach (VRInteractiveItem location in teleportLocations){
            location.OnClick -= Teleport;
        }
    }

    // Si existe la accion DoTeleport, la llamamos para realizar el traslado.
    void Teleport(){
        if (DoTeleport != null){
            DoTeleport(reticleTransform);
        }else{
            Debug.Log("DoTeleport event has no subscribers.");
        }
    }
	//Testing xlink changes on read only
}
