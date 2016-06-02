using UnityEngine;
using System.Collections;

public class moveMerchandise : MonoBehaviour 
{

	public int speed = 3;
	private Rigidbody rb;

	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		rb.MovePosition (transform.position + (transform.right*speed) * Time.deltaTime);
	}
}
