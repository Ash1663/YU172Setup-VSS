using System;
using UdonSharp;
using UnityEngine;

namespace nekobako {
	public class AnalogClock : UdonSharpBehaviour {
		[SerializeField]
		private Transform HourHand = null;

		[SerializeField]
		private Transform MinuteHand = null;

		[SerializeField]
		private Transform SecondHand = null;


		private void Update() {
			float milliseconds = (float)DateTime.Now.TimeOfDay.TotalMilliseconds;

			this.HourHand.localRotation = Quaternion.AngleAxis(milliseconds / 1000.0f / 60.0f / 60.0f / 12.0f * 360.0f, Vector3.forward);
			this.MinuteHand.localRotation = Quaternion.AngleAxis(milliseconds / 1000.0f / 60.0f / 60.0f * 360.0f, Vector3.forward);
			this.SecondHand.localRotation = Quaternion.AngleAxis(milliseconds / 1000.0f / 60.0f * 360.0f, Vector3.forward);
		}
	}
}
