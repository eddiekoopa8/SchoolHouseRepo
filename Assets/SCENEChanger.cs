using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class SCENEChanger : MonoBehaviour
{
    public string scene;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SCENEManager.ChangeScene(scene);
        }
    }
}
