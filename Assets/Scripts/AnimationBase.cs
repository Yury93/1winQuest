using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

    /// <summary>
    /// Базовый класс анимаций
    /// </summary>
    public abstract class AnimationBase : MonoBehaviour
    {
        /// <summary>
        ///  Полное время анимации
        /// </summary>
        [SerializeField] protected float m_AnimationTime;
        /// <summary>
        ///  Полное время анимации с учётом скелинга
        /// </summary>
        public float AnimationTime => m_AnimationTime / m_AnimationScale;
        /// <summary>
        /// келинг времени анимаций
        /// </summary>
        [SerializeField] protected float m_AnimationScale;
        public void SetAnimationScale(float scale)
        {
            m_AnimationScale = scale;
        }
        [SerializeField] private bool m_AnimateActive;
        /// <summary>
        /// Флаг повторения анимации
        /// </summary>
        [SerializeField] private bool m_Looping;
        /// <summary>
        /// Анимация задом наперёд
        /// </summary>
        [SerializeField] private bool m_Reserve;

        [SerializeField] private UnityEvent m_EventStart;
        public UnityEvent EventStart => m_EventStart;
        [SerializeField] private UnityEvent m_EventEnd;
        public UnityEvent EventEnd => m_EventEnd;

        private float m_Timer;

        private bool m_AnimationPlaying;
        

        /// <summary>
        /// Нормализованное время от 0 до 1
        /// </summary>
        public float NormalizedAnimationTime
        {
            get
            {
                var t = Mathf.Clamp01(m_Timer / m_AnimationTime);
                return m_Reserve ? (1.0f - t) : t; 
            }
        }
        #region Public API
        /// <summary>
        /// Метод запуска анимации
        /// </summary>
        /// <param name="prepare"></param>
        public void StartAnimation(bool prepare = true)
        {
            if(m_AnimationPlaying)
            { return; }
            if(prepare)
            {
                PrepareAnimation();
            }
            m_AnimationPlaying = true;
            OnAnimationStart();
            m_EventStart?.Invoke();
        }
        /// <summary>
        /// Метод остановки анимации
        /// </summary>
        public void StopAnimation()
        {
            if (!m_AnimationPlaying)
            { return; }
            m_AnimationPlaying = false;
            OnAnimationEnd();
            m_EventEnd?.Invoke();
        }
        #endregion
        #region UnityEvents
        private void Update()
        {
            if (m_AnimationPlaying)
            {
                m_Timer += Time.deltaTime;
                AnimateFrame();

                if (m_Timer > m_AnimationTime)
                {
                    if (m_Looping)
                    {
                        m_Timer = 0;
                    }
                    else
                    {
                        StopAnimation();
                    }
                }
            }
         
        }
        #endregion
        /// <summary>
        /// Анимируем текущий фрейм
        /// </summary>
        protected abstract void AnimateFrame();
        protected abstract void OnAnimationStart();
        protected abstract void OnAnimationEnd();
        /// <summary>
        /// Подготавливаем начальное состояние анимации
        /// </summary>
        public abstract void PrepareAnimation();
    public bool AnimaActive(bool anima)
    {
        //m_Looping = anima;
        m_AnimationPlaying = anima;
        return m_AnimationPlaying;
    }
    }
