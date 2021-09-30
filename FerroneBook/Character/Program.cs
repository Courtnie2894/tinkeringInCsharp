using System.Collections;
using System.Collections.Generic;
// using UnityEngine;

public class Character
{
    public string name;
    public int experience = 5;
    
    // A basic constructor
    public Character()
    {
        name = "Default Name";
    }

    // Another constructor!
    public Character(string name)
    {
        this.name = name; //read: the name variable of the class Character (this.name) is the parameter (name)
    }
    public void PrintStats()
    {
        Debug.Log($"Name: {name}, Experience: {experience}");
    }
    private void Reset()
    {
        name = "Default Name";
        experience = 0; 
    }
}
public class Paladin : Character
{
    // Any  instances of Paladin class will have access to name and experience properties, as well as a PrintStats() method
    // but not! the private Reset()?
    public Weapon weapon;

    public Paladin(): base()
    {
        // Now Paladin has called the parent class (Character's) base constructor!
    }
    public Paladin(string name): base(name)
    {

    }
    public Paladin(string name, Weapon weapon): base(name)
    {
        this.weapon = weapon;
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }
    public void PrintStats()
    {
        Debug.Log($"Weapon: {name}, Damage: {damage}");
    }
}