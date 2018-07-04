using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog { } // наш класс пса

public class TestScript : MonoBehaviour
{
    int number = 1; // целые числа
    public string myName = "Енот"; // строка
    float anotherNumber = 0.6f; // вещественное число
    char symbol = 'r'; // символ
    bool answer = true; // логический типа - либо true либо false 
    TestScript test; // свой тип
    Dog dog; // еще свой тип


	// Срабатывает в начале игры
	void Start()
    {
        Debug.Log("Лалалала Игла"); 
	}
	
	// Срабатывает каждый кадр
	void Update ()
    {
        Debug.Log(myName);
        //number++;
        //number = number + 2;
        number += 2;
        Debug.Log(number);
    }
}

