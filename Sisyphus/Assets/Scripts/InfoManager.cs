using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoManager : MonoBehaviour
{
    public const int Level1 = 1;
    
    public Texture backGround;
    
    private int gameStage = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameStage)
        {
            case 1:
                CreateLevel1();
                break;
        }
    }

    void CreateLevel1()
    {
        //GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height),backGround);
    }
}
