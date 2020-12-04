using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private Transform followTarget = null;

	private void Start()
	{
		followTarget = GameObject.FindGameObjectWithTag(Player.Tag).transform;
	}

	private void Update()
	{
		var pos = transform.position;
		pos.x = followTarget.position.x;
		transform.position = pos;
	}
}
