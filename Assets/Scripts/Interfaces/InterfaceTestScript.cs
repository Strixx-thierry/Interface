using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start runs once when Play is pressed
    void Start()
    { 

        // Trapezium declaration
        Trapezium trapezium = new Trapezium();
        trapezium.CalculateUnknownSides();
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        // Circle declaration
        Circle circle = new Circle();
        circle.CalculateRadius(); 
        circle.CalculateArea();
        circle.CalculatePerimeter();

        // Nonagon declaration
        Nonagon nonagon = new Nonagon();
        Debug.Log("Nonagon number of sides: " + nonagon.CalculateNumberOfSides());
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();

    }

    void Update()
    {

    }
}

// Shared interface: only the methods common to ALL shapes
public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    // top parallel side
    float sideA = 12f;
    // bottom parallel side
    float sideB = 7f;
    float height = 6f;
    float legC = 5.5f;
    float legD = 5.5f;

    public void CalculateUnknownSides()
    {
        // Simulated calculation for an unknown leg using arbitrary values
        legD = Mathf.Sqrt((height * height) + 1f);
        Debug.Log("Trapezium unknown side (legD): " + legD);
    }

    public void CalculateArea()
    {
        float area = ((sideA + sideB) / 2f) * height;
        Debug.Log("Trapezium area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = sideA + sideB + legC + legD;
        Debug.Log("Trapezium perimeter: " + perimeter);
    }
}

public class Circle : IShape
{
    float radius;
    float diameter = 14f;

    public void CalculateRadius()
    {
        radius = diameter / 2f;
        Debug.Log("Circle radius: " + radius);
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle area: " + area);
    }

    public void CalculatePerimeter()
    {
        // Perimeter of a circle is its circumference
        float circumference = 2f * Mathf.PI * radius;
        Debug.Log("Circle perimeter (circumference): " + circumference);
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;
    float sideLength = 8f;

    public void CalculateArea()
    {
        
        float area = (9f / 4f) * (sideLength * sideLength) / Mathf.Tan(Mathf.PI / 9f);
        Debug.Log("Nonagon area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon perimeter: " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}