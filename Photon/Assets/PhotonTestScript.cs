using UnityEngine;
using System.Collections;

public class PhotonTestScript : MonoBehaviour {

	string unitychan = "unitychan";
	private PhotonView myPhotonView;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("0.1");
	
	}

	void OnJoinedLobby()
	{
		Debug.Log("JoinRandom");
		PhotonNetwork.JoinRandomRoom();
	}
	
	void OnPhotonRandomJoinFailed()
	{
		PhotonNetwork.CreateRoom(null);
	}
	
	void OnJoinedRoom()
	{
		GameObject monster = (GameObject) PhotonNetwork.Instantiate(unitychan, Vector3.zero, Quaternion.identity, 0);
		//monster.GetComponent<myThirdPersonController>().isControllable = true;
		myPhotonView = monster.GetComponent<PhotonView>();
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
