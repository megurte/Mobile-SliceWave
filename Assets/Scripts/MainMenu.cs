using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public void loadClassicMode()
    {
        Application.LoadLevel("ClassicMode");
    }


    //change latter
    public void loadArcadeMode()
    {
        Application.LoadLevel("ArcadeMode");
    }

    //change latter

    public void loadHardcoreMode()
    {
        Application.LoadLevel("HardcoreMode");
    }

    public void loadChooseMenu()
    {
        Application.LoadLevel("Lobby");
    }

    public void loadMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }


}
