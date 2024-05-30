using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertebrateAnimal : AnimalFactory
{
    public override IAnimal CreateAnimal()
    {
        return new InvertebrateComportament();
    }
}
