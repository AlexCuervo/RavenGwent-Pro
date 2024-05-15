using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassTurn : MonoBehaviour
{
    public bool isPlayingP1 = true;
    public bool isPlayingP2 = true;
    
    public void OnClick()
    {
        
        if (gameObject.name == "MyPassButton" && isPlayingP1 == true)
        {
            isPlayingP1 = false;    
        }
    
        else if (gameObject.name == "EnemyPassButton" && isPlayingP2 == true)
        {
            isPlayingP2 = false;
        }
    }

    
    
    
    
}
