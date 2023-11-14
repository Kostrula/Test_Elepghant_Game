using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click_on_zombi : MonoBehaviour
{
    public Animator animator;

    public void OnMouseDown()
    {
        StartCoroutine(DeadCo());
    }

    private IEnumerator DeadCo()
    {
        animator.SetBool("Dead", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("Dead", false);
    }
}
