using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment29
{
    public class TypeManagementScript : MonoBehaviour
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Debug.Log("Animal sound");
            }
            public void Move()
            {
                Debug.Log("Animal moves");
            }
        }
        public class Cat : Animal, ICanFight
        {
            public override void MakeSound()
            {
                Debug.Log("Meow!");
            }
            public void Move()
            {
                Debug.Log("Cat runs quickly");
            }
            public void Attack()
            {
                Debug.Log("Cat attacks with claws!");
            }
        }
        void Start()
        {
            Animal animal = new Cat();
            animal.MakeSound();
            animal.Move();

            Cat cat = animal as Cat;
            if (cat != null)
            {
                cat.MakeSound();
                cat.Move();
            }
            List<ICanFight> fighter = new List<ICanFight>();
            Cat cat1 = new Cat();
            Warrior warrior = new Warrior();
            fighter.Add(cat1);
            fighter.Add(warrior);

            foreach (ICanFight Fighter in fighter)
            {
                Fighter.Attack();
            }
            foreach (ICanFight Fighter in fighter)
            {
                if (Fighter is Cat)
                {
                    Debug.Log("The object is a Cat.");
                }
                else if (Fighter is Warrior)
                {
                    Debug.Log("The object is a Warrior.");
                }
            }
        }
    }
    public interface ICanFight
    {
        void Attack();
    }
    public class Warrior : ICanFight
    {
        public void Attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }
}

