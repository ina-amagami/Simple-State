using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Fix : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        meshRenderer.material.color = Color.red;
    }

    private void OnTriggerExit(Collider other)
    {
        meshRenderer.material.color = Color.blue;
    }

	private void OnDestroy()
	{
        Destroy(meshRenderer.material);
	}
}
