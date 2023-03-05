using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Cell cell;
    public int w;
    public int h;
    public int scale;
    public static Dictionary<Vector2, Cell> _tiles = new Dictionary<Vector2, Cell>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                var cell_temp = Instantiate(cell, new Vector3((i + 0.5f) * scale, (j + 0.5f) * scale), Quaternion.identity);
                cell_temp.transform.localScale = new Vector3(1 * scale, 1 * scale, 0);
                cell_temp.name = $"Cell [{i},{j}]";
                cell_temp.X = i;
                cell_temp.Y = j;
                
                var isOffset = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
                cell_temp.Init(isOffset);
                _tiles[new Vector2(i, j)] = cell_temp;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//
//