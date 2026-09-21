using UnityEngine;

public class Character : MonoBehaviour
{
protected Health health;
protected Collider charecterCollider;
protected Animator charecterAnimator;
protected virtual void Awake()
{
    health = GetComponent<Health>();
    charecterCollider = GetComponent<Collider>();
    charecterAnimator = GetComponent<Animator>();
}
}
