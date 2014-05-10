using UnityEngine;
using System.Collections;

public class SlowRotation : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up, 20f * Time.deltaTime);	
	}
}
