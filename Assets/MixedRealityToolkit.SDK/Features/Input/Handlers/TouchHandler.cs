using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Input
{
    public class TouchHandler : MonoBehaviour, IMixedRealityTouchHandler
    {

        #region Event handlers
        public TouchEvent OnTouchStarted = new TouchEvent();
        public TouchEvent OnTouchCompleted = new TouchEvent();
        public TouchEvent OnTouchUpdated = new TouchEvent();
        #endregion

        private void Awake()
        {
            OnTouchStarted.AddListener(delegate { TestFunction(); });
        }

        void IMixedRealityTouchHandler.OnTouchCompleted(HandTrackingInputEventData eventData)
        {
            OnTouchCompleted.Invoke(eventData);
            Debug.Log("Completed");
        }

        void IMixedRealityTouchHandler.OnTouchStarted(HandTrackingInputEventData eventData)
        {
            OnTouchStarted.Invoke(eventData);
            Debug.Log("Started");
        }

        void IMixedRealityTouchHandler.OnTouchUpdated(HandTrackingInputEventData eventData)
        {
            OnTouchUpdated.Invoke(eventData);
            Debug.Log("Updated");
        }

        private void TestFunction()
        {
            Debug.Log("Test function ");
        }
    }
}
