using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneMovement : MonoBehaviour
{
	[SerializeField] Rigidbody CraneRigidbody;
	[SerializeField] Rigidbody CraneHoistRigidbody;
	[SerializeField] Rigidbody CraneHookRigidbody;

	//bool isCraneMovingUp;
	//bool isCraneMovingDown;
	//bool isCraneMovingRight;
	//bool isCraneMovingLeft;
	//bool isCraneMovingForward;
	//bool isCraneMovingBackward;

	[SerializeField] float CraneUpSpeed;
	[SerializeField] float CraneDownSpeed;
	[SerializeField] float CraneRightSpeed;
	[SerializeField] float CraneLeftSpeed;
	[SerializeField] float CraneForwardSpeed;
	[SerializeField] float CraneBackwardSpeed;
	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		//if(isCraneMovingUp) 
		//if (isCraneMovingDown;
		//if (isCraneMovingRight;
		//if (isCraneMovingLeft;
		//if (isCraneMovingForward;
		//if (isCraneMovingBackward;
	}
	private void FixedUpdate()
	{
		
	}
	public void MoveCraneUp()
	{

		//CraneHookRigidbody.gameObject.GetComponent<ConfigurableJoint>().linearLimit = new SoftJointLimit()
		//{
		//	limit = Mathf.Clamp(Mathf.Lerp(CraneHookRigidbody.transform.position.y, CraneHookRigidbody.transform.position.y + CraneUpSpeed * CraneHookRigidbody.transform.up.y, 0.1f), 0, 4.5f)
		//};
		CraneHookRigidbody.AddForce(CraneUpSpeed * transform.up, ForceMode.Force);
		//isCraneMovingUp = true;
	}
	public void MoveCraneDown()
	{
		//CraneHookRigidbody.gameObject.GetComponent<ConfigurableJoint>().linearLimit = new SoftJointLimit()
		//{
		//	limit = Mathf.Clamp(Mathf.Lerp(CraneHookRigidbody.transform.position.y, CraneHookRigidbody.transform.position.y + CraneDownSpeed * -CraneHookRigidbody.transform.up.y, 0.1f), 0, 4.5f)
		//};
		CraneHookRigidbody.AddForce(CraneDownSpeed * -transform.up, ForceMode.Force);
		//isCraneMovingDown = true;
	}
	public void MoveCraneRight()
	{
		//CraneHoistRigidbody.position = (Vector3.Lerp(CraneHoistRigidbody.transform.position, CraneHoistRigidbody.transform.position + CraneRightSpeed * transform.right, 0.5f));
		CraneHoistRigidbody.AddForce(CraneRightSpeed * transform.right, ForceMode.Force);
		//isCraneMovingRight = true;

	}
	public void MoveCraneLeft()
	{
		//CraneHoistRigidbody.position = (Vector3.Lerp(CraneHoistRigidbody.transform.position, CraneHoistRigidbody.transform.position + CraneRightSpeed * -transform.right, 0.5f));
		CraneHoistRigidbody.AddForce(CraneLeftSpeed * -transform.right, ForceMode.Force);
		//isCraneMovingLeft = true;
	}
	public void MoveCraneForward()
	{

		CraneRigidbody.AddForce(CraneForwardSpeed * transform.forward, ForceMode.Force);
		//isCraneMovingForward = true;
	}
	public void MoveCraneBackward()
	{

		CraneRigidbody.AddForce(CraneBackwardSpeed * -transform.forward, ForceMode.Force);
		//isCraneMovingBackward = true;
	}
}
