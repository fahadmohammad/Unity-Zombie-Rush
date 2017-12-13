using UnityEngine;
using System.Collections;

public class Rock : Object {

	[SerializeField] Vector3 topPositon;
	
	[SerializeField] Vector3 bottomPosition;

	[SerializeField] float speed;
	
	// Use this for initialization
	void Start () {
		StartCoroutine(Move(bottomPosition));
	}
	
	// Update is called once per frame

	protected override void Update()
	{
		if(GameManager.instance.PlayerActive)
		{
			base.Update();
		}
		
	}
	IEnumerator Move(Vector3 target)
	{
		while ( Mathf.Abs((target - transform.localPosition ).y) > 0.20f )
		{
			Vector3 direction = target.y == topPositon.y ? Vector3.up : Vector3.down;
			transform.localPosition += direction * Time.deltaTime * speed;
			yield return null;
		}
		//print {"Reached The Target!!"};
		yield return new WaitForSeconds(0.5f);
		Vector3 newTarget = target.y == topPositon.y ? bottomPosition : topPositon;
		
		StartCoroutine (Move (newTarget));
	}
}
