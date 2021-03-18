using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour
{
    public Text hud;
    public int characterLevel = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        hud = GameObject.FindGameObjectWithTag("LevelText").GetComponent<Text>();
        hud.text = "Character Level : " + characterLevel;
        Debug.Log(characterLevel);
    }
}
