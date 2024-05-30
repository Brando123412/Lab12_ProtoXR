using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AnimalFactory : MonoBehaviour,IAnimal
{
    [SerializeField] protected string typeAnimal;

    public abstract IAnimal CreateAnimal();
    public void Breed() { }
    public void Onomatopoeia() { }
}
