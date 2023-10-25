using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : Controller
{
    protected override void ApplyEffect()
    {
        float randomNumberScale = Random.Range(0.5f, 1.9f);
        transform.localScale = new Vector2(randomNumberScale, randomNumberScale);
    }
}
