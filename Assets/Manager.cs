using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class Date{
	public int year;
	public int month;
	public int day;
}
[Serializable]
public class CurrentDateText{
	public string year;
	public string month;
	public string day;
	public Text yearText;
	public Text monthText;
	public Text dayText;
}

public class Manager : MonoBehaviour {

	public Date date = new Date();
	public CurrentDateText dateText = new CurrentDateText ();

	// Use this for initialization
	void Start () {
		date.year = DateTime.Now.Year;
		date.month = DateTime.Now.Month;
		date.day = DateTime.Now.Day;

		dateText.year = date.year.ToString ();
		dateText.month = date.month.ToString ();
		dateText.day = date.day.ToString ();

		dateText.yearText.text = dateText.year;
		dateText.monthText.text = dateText.month;
		dateText.dayText.text = dateText.day;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
