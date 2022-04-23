using UnityEngine;
using System.Collections;

public class Camera_script : MonoBehaviour {
	public GameObject cameraPlayer;
	public GameObject cameraEndPoint;
	
	public float smoothTime = 0.1f;    // time for dampen
	public bool cameraFollowX = true; // camera follows on horizontal
	public bool cameraFollowY = true; // camera follows on vertical
	public bool cameraFollowHeight = true; // camera follow CameraTarget object height
	public float cameraHeight = 2.5f; // height of camera adjustable
	public Vector2 velocity; // speed of camera movement

	private Transform thisTransform; // camera Transform
	private float beginCamera;
	private float endCamera;
	
	void Start()
	{
		Screen.SetResolution(1280, 600, false);
		beginCamera = this.transform.position.x;
		endCamera = cameraEndPoint.transform.position.x;
		thisTransform = transform;
	}

	void FixedUpdate()
	{			
		if(beginCamera < cameraPlayer.transform.position.x && cameraPlayer.transform.position.x < endCamera)
		{
			if (cameraFollowX)
			{
				thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, cameraPlayer.transform.position.x, ref velocity.x, smoothTime), thisTransform.position.y, thisTransform.position.z);
			}
			/*if (cameraFollowY){}
			if (!cameraFollowX & cameraFollowHeight){}*/
		}	
	}
}