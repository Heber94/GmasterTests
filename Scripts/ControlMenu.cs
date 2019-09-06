using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ControlMenu : MonoBehaviour
{
    public void MenuButtonClick(int index){

        switch (index) {
            case 0:
                //Comenzar
                UnityEngine.SceneManagement.SceneManager.LoadScene(1);
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
//Testing for zendesk and preparing a conflict
