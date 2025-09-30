using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class DisplayDistance : MonoBehaviour
{
	[SerializeField] string DangerZoneTag = "DangerZone";
	[SerializeField] TMP_Text DisplayText;

	void Update()
	{
		DisplayText.text = GetClosestObjectDistance(GetAllTaggedObjects(DangerZoneTag), transform).ToString();
	}

	List<GameObject> GetAllTaggedObjects(string Tag)
	{
		List<GameObject> _result = new List<GameObject>();

		_result.AddRange(GameObject.FindGameObjectsWithTag(Tag));

		return _result;
	}
	//TODO: Check optimization and obj size
	//DOES NOT ACCOUNTING OBJECTS SIZES. TO GET IT SOMEWHAT CHECKING SIZES: DANGER ZONE NEEDS COLLIDER(TRIGGER MB)
	//THEN IN THIS METHOD CHECK VECTOR.DISTANCE() - (COLLIDER SIZE * OBJECT SCALE) OR RAYCAST TO OBJECT
	string GetClosestObjectDistance(List<GameObject> Objects, Transform CloseTo)
	{
		return Objects.OrderBy(o => Vector3.Distance(o.transform.position, CloseTo.position)).Select(o=>Vector3.Distance(o.transform.position, CloseTo.position).ToString("F2")).FirstOrDefault();
	}
}
