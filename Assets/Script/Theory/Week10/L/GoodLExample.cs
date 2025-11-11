using System;
using UnityEngine;

public class GoodLExample : MonoBehaviour
{
    public class Animal // คลาสพื้นฐานสำหรับสัตว์
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Bird : Animal
    {
        public virtual void LayEgg()
        {
            Debug.Log("Bird is laying eggs");
        }
    }




    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : Bird, IFlyable
    {
        public void Fly()
        {
            Debug.Log("Sparrow is flying");
        }

    }

    public class Ostrich : Bird
    {
        public void Run()
        {
            Debug.Log("Ostrch is running.");
        }
    }


   
}
