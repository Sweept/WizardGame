using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	//public Transform spawnLocation;
	public GameObject character;

	public void Awake() {
		GameObject spawnLocation = Instantiate(character) as GameObject;

	}
}