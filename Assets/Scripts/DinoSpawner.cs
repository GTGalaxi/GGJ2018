﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoSpawner : MonoBehaviour {

	public GameObject dino;
	public Terrain terrain;
	public int count;

	// Use this for initialization
	void Start () {
		Mesh planeMesh = GetComponent<MeshFilter>().mesh;
		Bounds bounds = planeMesh.bounds;
		for (int i = 0; i < count; i++) {
			float dx = transform.localScale.x * bounds.size.x * 0.5f;
			float dz = transform.localScale.z * bounds.size.z * 0.5f;

			Vector3 newVec = new Vector3(
				transform.position.x + Random.Range (-dx, dx),
				transform.position.y,
				transform.position.z + Random.Range (-dz, dz));
			newVec.y = terrain.SampleHeight (newVec) + terrain.transform.position.y;
			Instantiate (dino, newVec, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}