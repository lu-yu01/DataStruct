using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//抽象类同时提供继承和接口元素。抽象类本身不能实例化。
//接口不包含方法的实现。
//一个类或结构可以实现多个接口。一个类可以继承一个基类，还可实现一个或多个接口。
//abstract方法没有函数体，子类一定要有对应方法的实现。
//多态就是多态就是父类引用指向子类对象，调用方法时会调用子类的实现，而不是父类的实现，这叫多态。
//子类的构造函数会依次执行基类的构造函数，没有异议。

public class Animal
{
    int age;
    public Animal(int _age)
    {
        age = _age;
        Debug.Log("Construct Aniaml!"); 
    }

    public void Eat()
    {
        Debug.Log("Animal Eat!");
    }

    public virtual void Birth()
    {
        Debug.Log("Animal Birth!");
    }

    public virtual void Move()
    {
        Debug.Log("Animal Move!");
    }

}

public class Mammal : Animal
{
    //public Mammal():base(0)
    //{
    //    Debug.Log("Construct Mammal");
    //}

    public Mammal(int _age) : base(_age)
    {
        Debug.Log("Construct Mammal");
    }

    public sealed override void Move()
    {
        //base.Move();
        Debug.Log("Mammal Move!");
    }
}

public class Sheep : Mammal
{
    public Sheep(int _age) : base(_age)
    {
        Debug.Log("Construct Sheep!");
    }

    public new void Eat()
    {
        Debug.Log("Sheep Eat!");
    }

    public override void Birth()
    {
        Debug.Log("Sheep Birth!");
    }

    public new void Move()
    {
        Debug.Log("Sheep Move!");
    }

}



public class Polymorphism : MonoBehaviour {

  
	void Start () {
        //  Sheep sheep = new Sheep();
          Animal animal = new Sheep(1);
        //  sheep.Eat();
          animal.Eat();
        //  animal.Birth();

      //  Animal animal = new Animal(1);
      //  Animal animal1 = new Mammal(1);
     //   Animal animal2 = new Sheep(1);
     //   Sheep sheep = new Sheep(1);

        animal.Birth();
     //   animal1.Move();
     //   animal2.Move();
     //   sheep.Move();

	}
	
}
