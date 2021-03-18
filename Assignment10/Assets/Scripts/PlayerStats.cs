using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public int currentLevel = 1;
    public TextSetter cv;
    public Text hud;

    public void Awake()
    {
        //cv = GameObject.FindGameObjectWithTag("Canvas").GetComponent<TextSetter>();
        hud = GameObject.FindGameObjectWithTag("LevelText").GetComponent<Text>();
        hud.text = ("Character Level: " + currentLevel);
    }

    public void LevelUp()
    {
        //cv = GameObject.FindGameObjectWithTag("Canvas").GetComponent<TextSetter>();
        currentLevel++;
        Debug.Log(currentLevel);
        //cv.characterLevel = currentLevel;
        hud = GameObject.FindGameObjectWithTag("LevelText").GetComponent<Text>();
        hud.text = ("Character Level: " + currentLevel);
    }

    public void ResetLevel()
    {
        //cv = GameObject.FindGameObjectWithTag("Canvas").GetComponent<TextSetter>();
        currentLevel = 1;
        //cv.characterLevel = currentLevel;
        hud = GameObject.FindGameObjectWithTag("LevelText").GetComponent<Text>();
        hud.text = "Character Level: " + currentLevel;
        Debug.Log(currentLevel);
    }

    


}
