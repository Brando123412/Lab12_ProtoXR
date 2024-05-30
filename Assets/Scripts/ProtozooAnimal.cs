using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtozooAnimal : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new ProtozooComportament();
    }
}
