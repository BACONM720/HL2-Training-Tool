// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    // Silly script that applies a rotation about the up axis on demand.
    [AddComponentMenu("Scripts/MRTK/Examples/Rotator")]

    public class Rotator : MonoBehaviour
    {
        public Transform target;
        public Transform partToRotate;
        public int x;
   


        public void FixedUpdate()
        {
            Rotate();
        }

        public void Rotate()
        {
            partToRotate.RotateAround(target.position, Vector3.forward, x * Time.deltaTime);
        }
    }
}