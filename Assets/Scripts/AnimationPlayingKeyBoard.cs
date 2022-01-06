using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimationPlayingKeyBoard : MonoBehaviour
{
    //[SerializeField] private KeyCode keyCode;
    [SerializeField] private AnimationBase[] m_Target;
    [SerializeField] private bool m_AnimateStart = true;

    private void Start()
    {
        for (int i = 0; i < m_Target.Length; i++)
        {
            if (m_Target[i]. AnimaActive(m_AnimateStart))
            {
                m_Target[i].StartAnimation(true);
            }
            else if (m_Target[i].AnimaActive(m_AnimateStart))
            {
                m_Target[i].StartAnimation(false);
            }
        }
    }
    // Update is called once per frame
    //void Update()
    //{
    //    if (m_Target.AnimaActive(m_AnimateStart))
    //    {
    //        m_Target.StartAnimation(true);
    //    }
    //    else
    //    {
    //        m_Target.StartAnimation(false);
    //    }

    //}
}
