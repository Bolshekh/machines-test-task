using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookLineConnect : MonoBehaviour
{
	LineRenderer lineRenderer;
	[SerializeField] Transform hookPosition;
	// Start is called before the first frame update
	void Start()
	{
		lineRenderer = GetComponent<LineRenderer>();
	}

	// Update is called once per frame
	void Update()
	{
		lineRenderer.SetPosition(1, hookPosition.localPosition - 30 * hookPosition.up);
	}
}
