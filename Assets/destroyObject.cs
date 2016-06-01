using UnityEngine;
using System.Collections;

public class destroyObject : MonoBehaviour 
{

	void OnTriggerEnter(Collider other)
	{
		Destroy (other.gameObject);
	}
}
