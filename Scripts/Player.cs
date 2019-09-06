using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    Vector3 playerPosition;       // Variable para almacenar el destino del movimiento.

    [SerializeField] float playerHeight = 11; //Altura del jugador, por defecto se dejará en 3, igual que la camara en el editor.

    //Se asigna el movimiento por teletransporte.
    void OnEnable(){    
        TeleportManager.DoTeleport += MoveTo;
    }

    void OnDisable(){
        TeleportManager.DoTeleport -= MoveTo;
    }

    // Metodo de movimiento en el que se asigna la nueva posición, se añade la altura del jugador al eje Y y finalmente se desplaza.
    // @param destTransform
    void MoveTo(Transform destTransform){
 
        playerPosition = destTransform.position;
        playerPosition.y += playerHeight;
        transform.position = playerPosition;
    }
}