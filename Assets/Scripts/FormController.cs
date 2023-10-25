using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormController : Controller
{
    private SpriteRenderer spriteRenderer;

    public Sprite[] _img;

    protected override void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        base.Awake();
    }
    protected override void ApplyEffect()
    {
        int randomNumberImg = Random.Range(0, 3);
        spriteRenderer.sprite = _img[randomNumberImg];
    }
}
