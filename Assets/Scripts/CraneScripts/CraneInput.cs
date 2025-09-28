using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CraneInput : MonoBehaviour
{
	public UnityEvent MoveUpCalled;
	public UnityEvent MoveDownCalled;
	public UnityEvent MoveRightCalled;
	public UnityEvent MoveLeftCalled;
	public UnityEvent MoveForwardCalled;
	public UnityEvent MoveBackwardCalled;

	void Update()
	{
		GetInputFromKeyboard();
	}
	void GetInputFromKeyboard()
	{
		if (Input.GetButton("Fire1"))
			MoveUpCalled?.Invoke();

		if (Input.GetButton("Fire2"))
			MoveDownCalled?.Invoke();

		if (Input.GetAxis("Horizontal") > 0)
			MoveRightCalled?.Invoke();

		if (Input.GetAxis("Horizontal") < 0)
			MoveLeftCalled?.Invoke();

		if (Input.GetAxis("Vertical") > 0)
			MoveForwardCalled?.Invoke();

		if (Input.GetAxis("Vertical") < 0)
			MoveBackwardCalled?.Invoke();
	}
}
