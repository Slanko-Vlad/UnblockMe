using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private bool isFree = true;
    private int x;
    private int y;

    public int X
    {
        get => x;
        set => x = value;
    }
    
    public int Y
    {
        get => y;
        set => y = value;
    }
    
    public bool IsFree
    {
        get => isFree;
        set => isFree = value;
    }
    
    [SerializeField] private Color _baseColor, _offsetColor;
    [SerializeField] private SpriteRenderer _renderer;

    public void Init(bool isOffset) {
        _renderer.color = isOffset ? _offsetColor : _baseColor;
    }
}
