using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private InvertebrateAnimal invertebrate;
    [SerializeField] private VertebrateAnimal vertebrate;
    [SerializeField] private ProtozooAnimal protozoo;

    private List<IAnimal> animals = new List<IAnimal>();


    public void CreateInvertebrateAnimal()
    {
        IAnimal animal = invertebrate.CreateAnimal();
        animals.Add(animal);
        animal.Breed();
        animal.Onomatopoeia();
        Instantiate(invertebrate.prefabs);
    }

    public void CreateVertebrateAnimal()
    {
        IAnimal animal = vertebrate.CreateAnimal();
        animals.Add(animal);
        animal.Breed();
        animal.Onomatopoeia();
        Instantiate(vertebrate.prefabs);
    }
    public void CreateProtozooAnimal()
    {
        IAnimal animal = protozoo.CreateAnimal();
        animals.Add(animal);
        animal.Breed();
        animal.Onomatopoeia();
        Instantiate(protozoo.prefabs);
    }
}
