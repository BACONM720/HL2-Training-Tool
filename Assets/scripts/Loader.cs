using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader
{

   public enum Scene
    {
        Menu,
        AirTap,
        DwellGazeControl,
        Moving_and_Placing,
        Resizing_and_Rotating,
        Voice_Controls
    }

public static void Load(Scene scene)
    {
        SceneManager.LoadScene(scene.ToString());

    }

}

