using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change_scene : MonoBehaviour
{
    public string scene_name;

    public void Change_Scene()
    {
        SceneManager.LoadScene(scene_name);
    }
}
