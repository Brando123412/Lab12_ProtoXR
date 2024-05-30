using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private InvertebrateAnimal invertebrate;
    [SerializeField] private VertebrateAnimal vertebrate;

    private List<IAnimal> animals = new List<IAnimal>();

    void Start()
    {
        CreateInvertebrateAnimal();
        CreateVertebrateAnimal();
    }

    public void CreateInvertebrateAnimal()
    {
        IAnimal animal = invertebrate.CreateAnimal();
        animals.Add(animal);
        animal.Breed();
        animal.Onomatopoeia();
    }

    public void CreateVertebrateAnimal()
    {
        IAnimal animal = vertebrate.CreateAnimal();
        animals.Add(animal);
        animal.Breed();
        animal.Onomatopoeia();
    }
}
