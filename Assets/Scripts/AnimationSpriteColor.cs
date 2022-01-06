using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace CustomAnimations
{
    public class AnimationSpriteColor : AnimationBase
    {
        [SerializeField] private Image[] m_Image;
        [SerializeField] private Color m_ColorA;
        [SerializeField] private Color m_ColorB;
        [SerializeField] private AnimationCurve m_Curve;

        protected override void AnimateFrame()
        {
            print("Смена цвета");
            for (int i = 0; i < m_Image.Length; i++)
            {
                m_Image[i].color = Color.Lerp(m_ColorA, m_ColorB, m_Curve.Evaluate(NormalizedAnimationTime));
            }
        }

        protected override void OnAnimationEnd()
        {
           
        }

        protected override void OnAnimationStart()
        {
            
        }

        public override void PrepareAnimation()
        {
            
        }
    }
}