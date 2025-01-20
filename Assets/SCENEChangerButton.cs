using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;
using UnityEditor.SearchService;

public class SCENEChangerButton : MonoBehaviour
{
    public string SceneName = "!! PLEASE FILL ME IN !!";
    public void Change()
    {
        SCENEManager.ChangeScene(SceneName);
    }
}
