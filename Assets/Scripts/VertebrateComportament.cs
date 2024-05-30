using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertebrateComportament : MonoBehaviour, IAnimal
{
    public void Breed() {
        Debug.Log("BReedVertebrate");
    }
    public void Onomatopoeia() {
        Debug.Log("OnomatopoeasVertebrate");
    }
}
