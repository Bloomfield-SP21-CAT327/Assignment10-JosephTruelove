using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeScene(0);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeScene(1);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeScene(2);
        }
    }

    public void ChangeScene(int num)
    {
        SceneManager.LoadScene(num);
    }
}
