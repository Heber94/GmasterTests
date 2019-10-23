using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenu : MonoBehaviour
{
    public void MenuButtonClick(int index){//This code is from my tfg.

        switch (index) {
            case 0:
                //Comenzar
                UnityEngine.SceneManagement.SceneManager.LoadScene(1); //Creating two conflicts
                break;
            case 1:
                //Salir
                Application.Quit();
                break;
            default:
                break;
        }
    }
}
//Just preparing a conflict and testing gmaster
//To show better
//Some more changes.