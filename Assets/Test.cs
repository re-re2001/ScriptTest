using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;

    public void Magic()
    {if(mp>=5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。"); }
        else { Debug.Log("MPが足りないため、魔法が使えない。"); }
    
        }

}






public class Test : MonoBehaviour
{
 
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        int[] points = { 10, 20, 30, 40, 50 };
        for (int i = 0; i < 5; i++)
        { Debug.Log(points[i]); }

        for (int i = 4; i > -1  ; i--)
        { Debug.Log(points[i]); }

        Boss boss = new Boss();

        boss.Magic();

        for (int a = 0; a < 10; a++)
        { boss.Magic(); }







    }

    }