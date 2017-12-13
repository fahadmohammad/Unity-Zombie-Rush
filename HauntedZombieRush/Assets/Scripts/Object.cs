using UnityEngine;
using System.Collections;

public class Object : MonoBehaviour {

	[SerializeField] private float objectSpeed = 1f;
	[SerializeField]private float resetPosition = 24.6f;
	[SerializeField] private float startPosition = -45.5f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	protected virtual void Update()
	{
		if(!GameManager.instance.GameOver)
		{
			transform.Translate(Vector3.right * (objectSpeed * Time.deltaTime));

			if (transform.localPosition.x >= resetPosition)
			{
				Vector3 newPos = new Vector3(startPosition, transform.position.y, transform.position.z);
				transform.position = newPos;
			}
		}
		
		
	
	}
}
