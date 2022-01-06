using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class AnimationUIScale : AnimationBase
    {
        [SerializeField] private Image[] m_image;
        [SerializeField] private AnimationCurve m_CurveX;
        [SerializeField] private AnimationCurve m_CurveY;

        private Vector2 m_IntialSize;

        private void Start()
        {
        for (int i = 0; i < m_image.Length; i++)
        {
            m_IntialSize = m_image[i].gameObject.transform.localScale;
        }
            
        }
    public override void PrepareAnimation()
    {
        var x = m_CurveX.Evaluate(0) * m_IntialSize.x;
        var y = m_CurveY.Evaluate(0) * m_IntialSize.y;
        for (int i = 0; i < m_image.Length; i++)
        {
            m_image[i].gameObject.transform.localScale = new Vector2(x, y);
        }
    }
        protected override void AnimateFrame()
        {
            var x = m_CurveX.Evaluate(NormalizedAnimationTime) * m_IntialSize.x;
            var y = m_CurveY.Evaluate(NormalizedAnimationTime) * m_IntialSize.y;
        for (int i = 0; i < m_image.Length; i++)
        {
            m_image[i].gameObject.transform.localScale = new Vector2(x, y);
        }
        }

        protected override void OnAnimationEnd()
        {
           
        }

        protected override void OnAnimationStart()
        {
          
        }
    }
