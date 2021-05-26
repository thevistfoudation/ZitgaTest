﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using LTAUnityBase.Base.Controller;
namespace LTAUnityBase.Base.UI.Effect
{
	[DisallowMultipleComponent]
	public class EffectBtnScale : BehaviourController, IPointerUpHandler, IPointerDownHandler,IEffect
	{
		public float toScale = 1.08f;
		public void OnPointerUp(PointerEventData eventData)
		{
			ScaleUpdate(new Vector3(0.7f, 0.7f, 0.7f));
		}

		public void OnPointerDown(PointerEventData eventData)
		{
			ScaleUpdate(Vector3.one * toScale);
		}

        public void ShowEffect()
        {
            throw new System.NotImplementedException();
        }

        public void HideEffect()
        {
            throw new System.NotImplementedException();
        }
    }
}
