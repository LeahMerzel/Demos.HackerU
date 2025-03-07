﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.OOP.DesignPatterns.CompositeDemos
{
    public class CompositePatternDemo
    {
        public static void Run()
        {
            // Create a tree structure
            Composite root = new Composite("root");
             root.Add(new Leaf("Leaf A"));
             root.Add(new Leaf("Leaf B"));
           
            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf XA"));
            comp.Add(new Leaf("Leaf XB"));

            root.Add(comp);

            Composite compY = new Composite("Composite Y");
            compY.Add(new Leaf("Leaf YA"));
            compY.Add(new Leaf("Leaf YB"));
            root.Add(compY);



            root.Add(new Leaf("Leaf C"));
            // Add and remove a leaf
            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            

            root.Remove(leaf);//Remove LeafD
            // Recursively display tree
            root.Display(1);
            // Wait for user
            Console.ReadKey();
        }
    }
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
    public abstract class Component
    {
        protected string name;
        // Constructor
        public Component(string name)
        {
            this.name = name;
        }
        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract void Display(int depth);
    }
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Composite : Component
    {
        List<Component> children = new List<Component>();
        // Constructor
        public Composite(string name)
            : base(name)
        {
        }
        public override void Add(Component component)
        {
            children.Add(component);
        }
        public override void Remove(Component component)
        {
            children.Remove(component);
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            // Recursively display child nodes
            foreach (Component component in children)
            {
                component.Display(depth + 2);
            }
        }
    }
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Leaf : Component
    {
        // Constructor
        public Leaf(string name)
            : base(name)
        {
        }
        public override void Add(Component c)
        {
            Console.WriteLine("Cannot add to a leaf");
        }
        public override void Remove(Component c)
        {
            Console.WriteLine("Cannot remove from a leaf");
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
