// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos.EyeTracking
{
    /// <summary>
    /// The associated GameObject will rotate when RotateTarget() is called based on a given direction and speed.
    /// </summary>
    [AddComponentMenu("Scripts/MRTK/Examples/RotateWithConstSpeedDir")]
    public class RotateWithConstSpeedDir : MonoBehaviour
    {
        #region Serialized variables

        [Tooltip("Euler angles by which the object should be rotated by.")]
        [SerializeField]
        private Vector3 RotateByEulerAngles = Vector3.zero;

        [Tooltip("Rotation speed factor.")]
        [SerializeField]
        private float speed = 1f;

        #endregion

        private void Update()
        {
            transform.eulerAngles = transform.eulerAngles + RotateByEulerAngles * speed;
            //StartCoroutine(RotateTarget());
        }
        /// <summary>
        /// Rotate game object based on specified rotation speed and Euler angles.
        /// </summary>
        public IEnumerator RotateTarget()
        {
            transform.eulerAngles = transform.eulerAngles + RotateByEulerAngles * speed;
            yield return new WaitForSeconds(10);
            speed = 0f;

        }
    }
}