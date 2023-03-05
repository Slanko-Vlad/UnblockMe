using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertical : MonoBehaviour
{
    
    public int length;
    private Transform trans;
    private Vector2[] vectArr;
    public Vector2Int startPos;
    private void Move(int x, int y)
    {
        foreach (var cord in vectArr)
        {
            GameManager._tiles[cord].IsFree = true;
        }
        
        trans.position = new Vector2(0.5f + x, (this.length * 0.5f) + y );
        vectArr[0] = new Vector2(x, y);
        if (length > 1)
        {
            for (int i = 1; i < length; i++)
            {
                vectArr[i] = new Vector2(x, y + i);
            }
        }

        foreach (var cord in vectArr)
        {
            GameManager._tiles[cord].IsFree = false;
        }
        
        
    }
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.transform;
        trans.localScale = new Vector2(1, length);
        
        vectArr = new Vector2[length];
        
        this.Move(startPos.x, startPos.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
