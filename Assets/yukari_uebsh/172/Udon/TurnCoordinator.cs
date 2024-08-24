
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

namespace Virtual172
{
    public class TurnCoordinator : UdonSharpBehaviour
    {
        public float angleScale = 1.0f;
        public float clampAngle = 20.0f;
        public Vector3 axis = Vector3.forward;

        private Rigidbody rigidbody;

        private void Start()
        {
            rigidbody = GetComponentInParent<Rigidbody>();
        }

        private void Update()
        {
            transform.localRotation = Quaternion.AngleAxis(
                Mathf.Clamp(rigidbody.angularVelocity.y * angleScale, -clampAngle, clampAngle),
                axis
            );
        }
    }
}