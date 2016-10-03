using UnityEngine;
using System.Collections;

public class CamMouseLook : MonoBehaviour {


	//public variables
	public float senstivity;
	public float smoothing;

	Vector2 mouseLook;
	Vector2 smoothV;

	//Reference to the player
	GameObject player;



	// Use this for initialization
	void Start () {
        //Reference to players position.
        player = transform.parent.gameObject;
	
	}
	
	// Update is called once per frame
	void Update () {

        //
        var mD = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        //
        mD = Vector2.Scale(mD, new Vector2(senstivity * smoothing, senstivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, mD.x ,1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, mD.y, 1f / smoothing);
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        player.transform.localRotation = Quaternion.AngleAxis(mouseLook.x ,player.transform.up);

        //mD = Vector2

    }
}
