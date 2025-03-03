
using UnityEngine;

public class SCENEChangerButton : MonoBehaviour
{
    public string SceneName = "!! PLEASE FILL ME IN !!";
    public void Change()
    {
        SCENEManager.ChangeScene(SceneName);
    }
}
