using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalFactory : MonoBehaviour,IAnimal
{
    [SerializeField] protected string typeAnimal;
    [SerializeField] public GameObject prefabs;
    public abstract IAnimal CreateAnimal();
    public void Breed() { }
    public void Onomatopoeia() { }
}
