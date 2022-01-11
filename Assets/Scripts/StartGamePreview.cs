using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGamePreview : MonoBehaviour
{
    [SerializeField] private AnimationBase animationSpriteColor;
    void Start()
    {
        animationSpriteColor = GetComponent<AnimationBase>();
        StartCoroutine(corDisable());
    }

    IEnumerator corDisable()
    {
        yield return new WaitForSeconds(animationSpriteColor.AnimationTime);
        DisableObj();
    }
    public void DisableObj()
    {
        gameObject.SetActive(false);
    }
}
