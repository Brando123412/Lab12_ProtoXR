using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VertebrateAnimal : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new VertebrateComportament();
    }
}
