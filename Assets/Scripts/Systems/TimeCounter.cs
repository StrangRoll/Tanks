using System;
using System.Collections;
using UnityEngine;

namespace Systems
{
    public class TimeCounter : MonoBehaviour
    {
        public void SetTimer(float time, Action callback)
        {
            StartCoroutine(Timer(time, callback));
        }

        private IEnumerator Timer(float time, Action callback)
        {
            yield return new WaitForSeconds(time);
            callback?.Invoke();
        }
    }
}