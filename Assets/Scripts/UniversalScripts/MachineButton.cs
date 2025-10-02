using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]
public class MachineButton : MonoBehaviour
{

	[SerializeField] float timeRequired;
	float timeEnter = 0, time = 0;

	[SerializeField] Slider uiHintSlider;

	public UnityEvent Action;
	private void Start()
	{
		uiHintSlider.minValue = 0;
		uiHintSlider.maxValue = timeRequired;
	}
	private void OnTriggerEnter(Collider other)
	{
		timeEnter = Time.time;

		uiHintSlider.gameObject.SetActive(true);
	}
	private void OnTriggerStay(Collider other)
	{
		if (timeEnter == 0) return;

		if (timeEnter + timeRequired < Time.time) Action?.Invoke();

		uiHintSlider.value = Time.time - timeEnter;
	}
	private void OnTriggerExit(Collider other)
	{
		timeEnter = 0;

		uiHintSlider.gameObject.SetActive(false);
	}
}
