using UnityEngine;
using System.Collections;

namespace Erp {
	public interface IInterpolator {
		void GetValue(float start, float end, float percentage);
	}
}
