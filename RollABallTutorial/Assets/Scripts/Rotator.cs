using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float TurnSpeed;
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 45, 0)*TurnSpeed * Time.deltaTime);
	}
}
