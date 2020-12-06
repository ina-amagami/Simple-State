using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
	private Player player = null;

	private void Start()
	{
		player = GameObject.FindGameObjectWithTag(Player.Tag).GetComponent<Player>();
	}

	private void Update()
	{
		if (player.IsDead)
		{
			return;
		}
		var pos = transform.position;
		pos.x = player.transform.position.x;
		transform.position = pos;
	}
}
