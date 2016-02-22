using UnityEngine;
using System.Collections;

public class ifStatements : MonoBehaviour 
{
	public float cellphoneBatteryLife = 100.0f;
	public float okBatteryLife = 60.0f;
	public float lowBatteryLife = 20.0f;

	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		cellphoneBatteryLife -= Time.deltaTime * 5f;
	}


	void TemperatureTest()
	{
		if(cellphoneBatteryLife > okBatteryLife) {
			Debug.Log("Battery life is great.");
		}
		else if(cellphoneBatteryLife < lowBatteryLife) 
		{
			Debug.Log("Battery life is low.");
		}
		else
		{
			Debug.Log("Battery life is OK.");
		}
	}
}
