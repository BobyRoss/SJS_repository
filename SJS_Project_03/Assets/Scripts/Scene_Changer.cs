using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Changer : MonoBehaviour
{
    public void changeScene(int SceneID){
        SceneManager.LoadScene(SceneID);
    }
}

