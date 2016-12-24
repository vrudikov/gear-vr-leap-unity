﻿using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class OverridenNetworkDiscovery : NetworkDiscovery {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OnReceivedBroadcast(string fromAddress, string data)
	{
		base.OnReceivedBroadcast(fromAddress, data);
		Debug.Log(fromAddress);
		NetworkManager.singleton.networkAddress = fromAddress;
		NetworkManager.singleton.StartClient();
	}
}