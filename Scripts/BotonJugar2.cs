﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BotonJugar2 : MonoBehaviour, IPointerClickHandler {


	public void OnPointerClick (PointerEventData pointerEventData)
	{
		SceneManager.LoadScene("EscenaSeleccionPersonajes2", LoadSceneMode.Single);
	}
}