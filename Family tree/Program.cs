using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree
{
    class Person
    {
        public bool IsDead = true;
        public string name;
        public int BirthDate;
        public int DieDate;
        public string Father;
        public string Mother;
        public string Grandfather;
        public string Grandmother;
        public void GetInfo()
        {
            if (IsDead)
                Console.WriteLine($"Name: {name} Born-Died: {BirthDate}-{DieDate}\nParents:\nFather-{Father}\nMother-{Mother}\nGrandparents:\nGrandfather-{Grandfather}\nGrandMother-{Grandmother}");
            else
            {
                Console.WriteLine($"Name: {name} Born-Died: {BirthDate}-????\nParents:\nFather-{Father}\nMother-{Mother}\nGrandparents:\nGrandfather-{Grandfather}\nGrandMother-{Grandmother}");
            }
        }
    }
    class FamilyTree
    {
        static void Main()
        {
            Person GGWP = new Person();
            GGWP.name = "GGWP";
            GGWP.BirthDate = 2000;
            GGWP.DieDate = 2020;
            GGWP.Father = "GG";
            GGWP.Mother = "WP";
            GGWP.Grandfather = "GL";
            GGWP.Grandmother = "HF";
            GGWP.GetInfo();
            Console.ReadKey();
        }
    }
}
