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
            Debug.Log("���@�U���������B�c��MP��" + this.mp + "�B"); }
        else { Debug.Log("MP������Ȃ����߁A���@���g���Ȃ��B"); }
    
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