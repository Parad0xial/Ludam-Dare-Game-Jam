using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnimation : MonoBehaviour
{
    public GameObject DeathEffectAnim;

    public void DeathEffect()
    {
        Instantiate(DeathEffectAnim, transform.position, Quaternion.identity);
	}
}
