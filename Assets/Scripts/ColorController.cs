using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : Controller
{
    private SpriteRenderer spriteRenderer;
    protected override void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        base.Awake();
    }
    protected override void ApplyEffect()
    {
        spriteRenderer.color = new Color(Random.value, Random.value, Random.value); 
    }
}
