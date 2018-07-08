using UnityEngine;
using System.Collections;

public class FastParticleDestroyer : MonoBehaviour {
	
	void Start (){
		Destroy(gameObject, 0.2f);
	}

}