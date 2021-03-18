using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int currentLevel;
	
    public void LevelUp()
    {
        currentLevel++;
        Debug.Log(currentLevel);

    }

    public void ResetLevel()
    {
        currentLevel = 1;
    }

    


}
