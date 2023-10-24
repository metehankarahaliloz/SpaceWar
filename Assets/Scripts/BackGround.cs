using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
	MeshRenderer meshRenderer;

	void Start()
	{
		meshRenderer = GetComponent<MeshRenderer>();
	}

	void Update()
	{
		float y = 0.3f * Time.time;
		meshRenderer.material.SetTextureOffset("_MainTex", new Vector2(0, y));
	}
}
