using UnityEngine;
using System.Collections;

public class ShowUIObject : MonoBehaviour
{
    [SerializeField]
    private string animationName;
    [SerializeField]
    private Pool pool;
    public void ShowObject(Transform parent)
    {
        pool.InstantiateObject(Vector3.zero);
        Transform obj = pool.CurrentObject.transform;
        obj.SetParent(parent);
        obj.localPosition = Vector3.zero;
        obj.localScale = Vector3.one;
        obj.localRotation = Quaternion.identity;

        Animator animator = obj.GetComponent<Animator>();
        StartCoroutine(PlayAnimation(animator));
    } 
    private IEnumerator PlayAnimation(Animator animator)
    {
        animator.Play(animationName, 0, 0f);
        yield return null;
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        animator.gameObject.SetActive(false);
    } 
}
