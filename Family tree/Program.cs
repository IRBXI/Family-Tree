using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Family_tree
{
    class Person
    {
        public bool HaveSpouse = false;
        public bool HaveChild0 = false;
        public bool HaveChild1 = false;
        public bool IsDead;
        public string name;
        public int BirthDate;
        public int DieDate;
        public string Child0Name;
        public string Child1Name;
        public string SpouseName;
        public string Parent0Name;
        public string Parent1Name;
        public void GetStandartInfo()
        {
            if (IsDead)
            {
                Console.WriteLine($"Name - {name} Years of life - {BirthDate}-{DieDate}");
            }
            else if (IsDead == false)
            {
                Console.WriteLine($"Name - {name} Years of life - {BirthDate}-????");
            }
        }
    }
    class FamilyTree
    {
        static void Main()
        {
            string Answer;
            bool UsingBranchCreator = false;
            bool UsingSelectingPerson = false;
            bool ReadyToCreateSecondBranch = false;
            byte People = 0;
            Person Person0 = new Person();
            Person Person1 = new Person();
            Person Person2 = new Person();
            Person Person3 = new Person();
            Person Person4 = new Person();
            Person Person5 = new Person();
            Person Person6 = new Person();
            Person Person7 = new Person();
            Person Person8 = new Person();
            Person Person9 = new Person();
            Person Person10 = new Person();
            Person Person11 = new Person();
            Person Person12 = new Person();
            Person Person13 = new Person();
            void ShowFamilyTree()
            {
                Console.WriteLine("                                                       |" + Person0.name + "|" + "--------|" + Person1.name + "|");

                
            }
            void ShowPeopleInfo()
            {
                if (Answer == Person0.name)
                {
                    Person0.GetStandartInfo();
                    if (Person0.HaveSpouse)
                    {
                        Console.WriteLine($"{Person0.name}'s Spouse - {Person0.SpouseName}");
                    }
                    if (Person0.HaveChild0)
                    {
                        Console.WriteLine($"{Person0.name}'s First Child - {Person0.Child0Name}");
                    }
                    if (Person0.HaveChild1)
                    {
                        Console.WriteLine($"{Person0.name}'s Second child - {Person0.Child1Name}");
                    }
                }
                else if (Answer == Person1.name)
                {
                    Person1.GetStandartInfo();
                    if (Person1.HaveSpouse)
                    {
                        Console.WriteLine($"{Person1.name}'s Spouse - {Person1.SpouseName}");
                    }
                    if (Person1.HaveChild0)
                    {
                        Console.WriteLine($"{Person1.name}'s First Child - {Person1.Child0Name}");
                    }
                    if (Person1.HaveChild1)
                    {
                        Console.WriteLine($"{Person1.name}'s Second child - {Person1.Child1Name}");
                    }
                }
                else if (Answer == Person2.name)
                {
                    Person2.GetStandartInfo();
                    Console.WriteLine($"{Person2.name}'s Parents - {Person2.Parent0Name} and {Person2.Parent1Name}");
                    if (Person2.HaveSpouse)
                    {
                        Console.WriteLine($"{Person2.name}'s Spouse - {Person2.SpouseName}");
                    }
                    if (Person2.HaveChild0)
                    {
                        Console.WriteLine($"{Person2.name}'s First Child - {Person2.Child0Name}");
                    }
                    if (Person2.HaveChild1)
                    {
                        Console.WriteLine($"{Person2.name}'s Second child - {Person2.Child1Name}");
                    }
                }
                else if (Answer == Person3.name)
                {
                    Person3.GetStandartInfo();
                    Console.WriteLine($"{Person3.name}'s Parents - {Person3.Parent0Name} and {Person3.Parent1Name}");
                    if (Person3.HaveSpouse)
                    {
                        Console.WriteLine($"{Person3.name}'s Spouse - {Person3.SpouseName}");
                    }
                    if (Person3.HaveChild0)
                    {
                        Console.WriteLine($"{Person3.name}'s First Child - {Person3.Child0Name}");
                    }
                    if (Person3.HaveChild1)
                    {
                        Console.WriteLine($"{Person3.name}'s Second child - {Person3.Child1Name}");
                    }
                }
                else if (Answer == Person4.name)
                {
                    Person4.GetStandartInfo();
                    Console.WriteLine($"{Person4.name}'s Parents - {Person4.Parent0Name} and {Person4.Parent1Name}");
                    if (Person4.HaveSpouse)
                    {
                        Console.WriteLine($"{Person4.name}'s Spouse - {Person4.SpouseName}");
                    }
                    if (Person4.HaveChild0)
                    {
                        Console.WriteLine($"{Person4.name}'s First Child - {Person4.Child0Name}");
                    }
                    if (Person4.HaveChild1)
                    {
                        Console.WriteLine($"{Person4.name}'s Second child - {Person4.Child1Name}");
                    }
                }
                else if (Answer == Person5.name)
                {
                    Person5.GetStandartInfo();
                    Console.WriteLine($"{Person5.name}'s Parents - {Person5.Parent0Name} and {Person5.Parent1Name}");
                    if (Person5.HaveSpouse)
                    {
                        Console.WriteLine($"{Person5.name}'s Spouse - {Person5.SpouseName}");
                    }
                    if (Person5.HaveChild0)
                    {
                        Console.WriteLine($"{Person5.name}'s First Child - {Person5.Child0Name}");
                    }
                    if (Person5.HaveChild1)
                    {
                        Console.WriteLine($"{Person5.name}'s Second child - {Person5.Child1Name}");
                    }
                }
                else if (Answer == Person6.name)
                {
                    Person6.GetStandartInfo();
                    Console.WriteLine($"{Person6.name}'s Parents - {Person6.Parent0Name} and {Person6.Parent1Name}");
                    if (Person6.HaveSpouse)
                    {
                        Console.WriteLine($"{Person6.name}'s Spouse - {Person6.SpouseName}");
                    }
                    if (Person6.HaveChild0)
                    {
                        Console.WriteLine($"{Person6.name}'s First Child - {Person6.Child0Name}");
                    }
                    if (Person6.HaveChild1)
                    {
                        Console.WriteLine($"{Person6.name}'s Second child - {Person6.Child1Name}");
                    }
                }
                else if (Answer == Person7.name)
                {
                    Person7.GetStandartInfo();
                    Console.WriteLine($"{Person7.name}'s Parents - {Person7.Parent0Name} and {Person7.Parent1Name}");
                    if (Person7.HaveSpouse)
                    {
                        Console.WriteLine($"{Person7.name}'s Spouse - {Person7.SpouseName}");
                    }
                    if (Person7.HaveChild0)
                    {
                        Console.WriteLine($"{Person7.name}'s First Child - {Person7.Child0Name}");
                    }
                    if (Person7.HaveChild1)
                    {
                        Console.WriteLine($"{Person7.name}'s Second child - {Person7.Child1Name}");
                    }
                }
                else if (Answer == Person8.name)
                {
                    Person8.GetStandartInfo();
                    Console.WriteLine($"{Person8.name}'s Parents - {Person8.Parent0Name} and {Person8.Parent1Name}");
                    if (Person8.HaveSpouse)
                    {
                        Console.WriteLine($"{Person8.name}'s Spouse - {Person8.SpouseName}");
                    }
                    if (Person8.HaveChild0)
                    {
                        Console.WriteLine($"{Person8.name}'s First Child - {Person8.Child0Name}");
                    }
                    if (Person8.HaveChild1)
                    {
                        Console.WriteLine($"{Person8.name}'s Second child - {Person8.Child1Name}");
                    }
                }
                else if (Answer == Person9.name)
                {
                    Person9.GetStandartInfo();
                    Console.WriteLine($"{Person9.name}'s Parents - {Person9.Parent0Name} and {Person9.Parent1Name}");
                    if (Person9.HaveSpouse)
                    {
                        Console.WriteLine($"{Person9.name}'s Spouse - {Person9.SpouseName}");
                    }
                    if (Person9.HaveChild0)
                    {
                        Console.WriteLine($"{Person9.name}'s First Child - {Person9.Child0Name}");
                    }
                    if (Person9.HaveChild1)
                    {
                        Console.WriteLine($"{Person9.name}'s Second child - {Person9.Child1Name}");
                    }
                }
                else if (Answer == Person10.name)
                {
                    Person10.GetStandartInfo();
                    Console.WriteLine($"{Person10.name}'s Parents - {Person10.Parent0Name} and {Person10.Parent1Name}");
                    if (Person10.HaveSpouse)
                    {
                        Console.WriteLine($"{Person10.name}'s Spouse - {Person10.SpouseName}");
                    }
                    if (Person10.HaveChild0)
                    {
                        Console.WriteLine($"{Person10.name}'s First Child - {Person10.Child0Name}");
                    }
                    if (Person10.HaveChild1)
                    {
                        Console.WriteLine($"{Person10.name}'s Second child - {Person10.Child1Name}");
                    }
                }
                else if (Answer == Person11.name)
                {
                    Person11.GetStandartInfo();
                    Console.WriteLine($"{Person11.name}'s Parents - {Person11.Parent0Name} and {Person11.Parent1Name}");
                    if (Person11.HaveSpouse)
                    {
                        Console.WriteLine($"{Person11.name}'s Spouse - {Person11.SpouseName}");
                    }
                    if (Person11.HaveChild0)
                    {
                        Console.WriteLine($"{Person11.name}'s First Child - {Person11.Child0Name}");
                    }
                    if (Person11.HaveChild1)
                    {
                        Console.WriteLine($"{Person11.name}'s Second child - {Person11.Child1Name}");
                    }
                }
                else if (Answer == Person12.name)
                {
                    Person12.GetStandartInfo();
                    Console.WriteLine($"{Person12.name}'s Parents - {Person12.Parent0Name} and {Person12.Parent1Name}");
                    if (Person12.HaveSpouse)
                    {
                        Console.WriteLine($"{Person12.name}'s Spouse - {Person12.SpouseName}");
                    }
                    if (Person12.HaveChild0)
                    {
                        Console.WriteLine($"{Person12.name}'s First Child - {Person12.Child0Name}");
                    }
                    if (Person12.HaveChild1)
                    {
                        Console.WriteLine($"{Person12.name}'s Second child - {Person12.Child1Name}");
                    }
                }
                else if (Answer == Person13.name)
                {
                    Person13.GetStandartInfo();
                    Console.WriteLine($"{Person13.name}'s Parents - {Person13.Parent0Name} and {Person13.Parent1Name}");
                    if (Person13.HaveSpouse)
                    {
                        Console.WriteLine($"{Person13.name}'s Spouse - {Person13.SpouseName}");
                    }
                    if (Person13.HaveChild0)
                    {
                        Console.WriteLine($"{Person13.name}'s First Child - {Person13.Child0Name}");
                    }
                    if (Person13.HaveChild1)
                    {
                        Console.WriteLine($"{Person13.name}'s Second child - {Person13.Child1Name}");
                    }
                }
            }
            void ChangePersonInfo()
            {
                Console.WriteLine("Write name of the person which Info you want to change");
                Answer = Console.ReadLine();
                if (Answer == Person0.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person0.name = Console.ReadLine();
                            Person1.SpouseName = Person0.name;
                            Person2.Parent0Name = Person0.name;
                            Person3.Parent0Name = Person0.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person0.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person0.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person0.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person1.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person1.name = Console.ReadLine();
                            Person0.SpouseName = Person1.name;
                            Person2.Parent1Name = Person1.name;
                            Person3.Parent1Name = Person1.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person1.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person1.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person1.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person2.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person2.name = Console.ReadLine();
                            Person4.SpouseName = Person2.name;
                            Person5.Parent0Name = Person2.name;
                            Person7.Parent0Name = Person2.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person2.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person2.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person2.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person3.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person3.name = Console.ReadLine();
                            Person8.SpouseName = Person3.name;
                            Person10.Parent0Name = Person3.name;
                            Person11.Parent0Name = Person3.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person3.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person3.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person3.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person4.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person4.name = Console.ReadLine();
                            Person2.SpouseName = Person4.name;
                            Person5.Parent1Name = Person4.name;
                            Person7.Parent1Name = Person4.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person4.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person4.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person4.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person5.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person5.name = Console.ReadLine();
                            Person6.SpouseName = Person5.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person5.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person5.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person5.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person6.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person6.name = Console.ReadLine();
                            Person5.SpouseName = Person6.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person6.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person6.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person6.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person7.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person7.name = Console.ReadLine();
                            Person9.SpouseName = Person7.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person7.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person7.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person7.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person8.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person8.name = Console.ReadLine();
                            Person3.SpouseName = Person8.name;
                            Person10.Parent1Name = Person8.name;
                            Person11.Parent1Name = Person8.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person8.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person8.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person8.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person9.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person9.name = Console.ReadLine();
                            Person7.SpouseName = Person9.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person9.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person9.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person9.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person10.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person10.name = Console.ReadLine();
                            Person12.SpouseName = Person10.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person10.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person10.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person10.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person11.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person11.name = Console.ReadLine();
                            Person13.SpouseName = Person11.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person11.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person11.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person11.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person12.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person12.name = Console.ReadLine();
                            Person10.SpouseName = Person12.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person12.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person12.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person12.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
                else if (Answer == Person13.name)
                {
                    Console.WriteLine("Now you need to write which Info you want to change");
                    Console.WriteLine("Write Name to change name\nWrite YearsOfLife to change years of life");
                    switch (Console.ReadLine())
                    {
                        case "Name":
                            Console.WriteLine("Write new name of the person");
                            Person13.name = Console.ReadLine();
                            Person11.SpouseName = Person13.name;
                            break;
                        case "YearsOfLife":
                            Console.WriteLine("Write new birth date");
                            Person13.BirthDate = Convert.ToInt32(Console.ReadLine());
                            if (Person13.IsDead)
                            {
                                Console.WriteLine("Write new die date");
                                Person13.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            break;
                    }
                }
            }
            void CreateBranch()
            {
                while (UsingBranchCreator)
                {


                    //Creating first person
                    Console.WriteLine("Write your first person's name");
                    Person0.name = Console.ReadLine();
                    Console.WriteLine($"Write {Person0.name} BirthDate");
                    Person0.BirthDate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Is {Person0.name} dead?\nWrite Yes or No");
                    Answer = Console.ReadLine();
                    if (Answer == "Yes")
                    {
                        Person0.IsDead = true;
                        Console.WriteLine($"Write {Person0.name} DieDate");
                        Person0.DieDate = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (Answer == "No")
                    {
                        Person0.IsDead = false;
                    }
                    //Creating First person's spouse
                    Console.WriteLine($"Now you need to create {Person0.name}'s spouse");
                    Console.WriteLine($"Write {Person0.name}'s spouse name");
                    Person1.name = Console.ReadLine();
                    Console.WriteLine($"Write {Person1.name} BirthDate");
                    Person1.BirthDate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Is {Person1.name} dead?\nWrite Yes or No");
                    Answer = Console.ReadLine();
                    if (Answer == "Yes")
                    {
                        Person1.IsDead = true;
                        Console.WriteLine($"Write {Person1.name} DieDate");
                        Person1.DieDate = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (Answer == "No")
                    {
                        Person1.IsDead = false;
                    }
                    Person0.SpouseName = Person1.name;
                    Person1.SpouseName = Person0.name;
                    Person0.HaveSpouse = true;
                    Person1.HaveSpouse = true;
                    People++;
                    //Creating child of first people
                    Console.WriteLine($"Now you need to create {Person0.name}'s and {Person1.name}'s first child");
                    Console.WriteLine($"Write {Person0.name}'s and {Person1.name} first child name");
                    Person2.name = Console.ReadLine();
                    Console.WriteLine($"Write {Person2.name} BirthDate");
                    Person2.BirthDate = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Is {Person2.name} dead?\nWrite Yes or No");
                    Answer = Console.ReadLine();
                    if (Answer == "Yes")
                    {
                        Person2.IsDead = true;
                        Console.WriteLine($"Write {Person2.name} DieDate");
                        Person2.DieDate = Convert.ToInt32(Console.ReadLine());
                    }
                    else if (Answer == "No")
                    {
                        Person2.IsDead = false;
                    }
                    Person0.Child0Name = Person2.name;
                    Person1.Child0Name = Person2.name;
                    Person2.Parent0Name = Person0.name;
                    Person2.Parent1Name = Person1.name;
                    Person0.HaveChild0 = true;
                    Person1.HaveChild0 = true;
                    People++;
                    //Creating spouse of first child
                    Console.WriteLine($"Does {Person2.name} have spouse?");
                    Console.WriteLine("Write Yes or No");
                    Answer = Console.ReadLine();
                    if (Answer == "Yes")
                    {
                        Console.WriteLine($"Now you need to create {Person2.name}'s spouse");
                        Console.WriteLine($"Write {Person2.name}'s wife or husband name");
                        Person4.name = Console.ReadLine();
                        Console.WriteLine($"Write {Person4.name} BirthDate");
                        Person4.BirthDate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Is {Person4.name} dead?\nWrite Yes or No");
                        Answer = Console.ReadLine();
                        if (Answer == "Yes")
                        {
                            Person4.IsDead = true;
                            Console.WriteLine($"Write {Person4.name} DieDate");
                            Person4.DieDate = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (Answer == "No")
                        {
                            Person4.IsDead = false;
                        }
                        Person2.SpouseName = Person4.name;
                        Person4.SpouseName = Person2.name;
                        Person2.HaveSpouse = true;
                        Person4.HaveSpouse = true;
                        People++;
                        Console.WriteLine($"Do {Person2.name} and {Person4.name} have child?");
                        Console.WriteLine("Write Yes or No");
                        Answer = Console.ReadLine();
                        if (Answer == "Yes")
                        {
                            //Creating first child of second parents
                            Console.WriteLine($"Write {Person2.name}'s and {Person4.name} first child name");
                            Person5.name = Console.ReadLine();
                            Console.WriteLine($"Write {Person5.name} BirthDate");
                            Person5.BirthDate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Is {Person5.name} dead?\nWrite Yes or No");
                            Answer = Console.ReadLine();
                            if (Answer == "Yes")
                            {
                                Person5.IsDead = true;
                                Console.WriteLine($"Write {Person5.name} DieDate");
                                Person5.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (Answer == "No")
                            {
                                Person5.IsDead = false;
                            }
                            Person2.Child0Name = Person5.name;
                            Person4.Child0Name = Person5.name;
                            Person5.Parent0Name = Person2.name;
                            Person5.Parent1Name = Person4.name;
                            Person2.HaveChild0 = true;
                            Person4.HaveChild0 = true;
                            People++;
                            Console.WriteLine($"Do {Person2.name} and {Person4.name} have second child?");
                            Console.WriteLine("Write Yes or No");
                            Answer = Console.ReadLine();
                            if (Answer == "Yes")
                            {
                                //Creating second child of second parents
                                Console.WriteLine($"Write {Person2.name}'s and {Person4.name} second child name");
                                Person7.name = Console.ReadLine();
                                Console.WriteLine($"Write {Person7.name} BirthDate");
                                Person7.BirthDate = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"Is {Person7.name} dead?\nWrite Yes or No");
                                Answer = Console.ReadLine();
                                if (Answer == "Yes")
                                {
                                    Person7.IsDead = true;
                                    Console.WriteLine($"Write {Person7.name} DieDate");
                                    Person7.DieDate = Convert.ToInt32(Console.ReadLine());
                                }
                                else if (Answer == "No")
                                {
                                    Person7.IsDead = false;
                                }
                                Person2.Child1Name = Person7.name;
                                Person4.Child1Name = Person7.name;
                                Person7.Parent0Name = Person2.name;
                                Person7.Parent1Name = Person4.name;
                                Person2.HaveChild1 = true;
                                Person4.HaveChild1 = true;
                                People++;
                                Console.WriteLine($"Does {Person5.name} have spouse");
                                Console.WriteLine("Write Yes or No");
                                Answer = Console.ReadLine();
                                if (Answer == "Yes")
                                {
                                    //Creating spouse of first child of second parents
                                    Console.WriteLine($"Now you need to create {Person5.name}'s spouse");
                                    Console.WriteLine($"Write {Person5.name}'s spouse name");
                                    Person6.name = Console.ReadLine();
                                    Console.WriteLine($"Write {Person6.name} BirthDate");
                                    Person6.BirthDate = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"Is {Person6.name} dead?\nWrite Yes or No");
                                    Answer = Console.ReadLine();
                                    if (Answer == "Yes")
                                    {
                                        Person6.IsDead = true;
                                        Console.WriteLine($"Write {Person6.name} DieDate");
                                        Person6.DieDate = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (Answer == "No")
                                    {
                                        Person6.IsDead = false;
                                    }
                                    Person6.SpouseName = Person5.name;
                                    Person5.SpouseName = Person6.name;
                                    Person6.HaveSpouse = true;
                                    Person5.HaveSpouse = true;
                                    People++;
                                    Console.WriteLine($"Does {Person7.name} have spouse");
                                    Console.WriteLine("Write Yes or No");
                                    Answer = Console.ReadLine();
                                    if (Answer == "Yes")
                                    {
                                        //Creating spouse of second child of second parents
                                        Console.WriteLine($"Now you need to create {Person7.name}'s spouse");
                                        Console.WriteLine($"Write {Person7.name}'s spouse name");
                                        Person9.name = Console.ReadLine();
                                        Console.WriteLine($"Write {Person9.name} BirthDate");
                                        Person9.BirthDate = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Is {Person9.name} dead?\nWrite Yes or No");
                                        Answer = Console.ReadLine();
                                        if (Answer == "Yes")
                                        {
                                            Person9.IsDead = true;
                                            Console.WriteLine($"Write {Person9.name} DieDate");
                                            Person9.DieDate = Convert.ToInt32(Console.ReadLine());
                                        }
                                        else if (Answer == "No")
                                        {
                                            Person9.IsDead = false;
                                        }
                                        Person7.SpouseName = Person9.name;
                                        Person9.SpouseName = Person7.name;
                                        Person7.HaveSpouse = true;
                                        Person9.HaveSpouse = true;
                                        People++;
                                    }
                                }
                            }
                        }
                    }
                                Console.WriteLine("You created first branch of the Family Tree");
                                Console.WriteLine($"Do {Person0.name} and {Person1.name} have second child");
                                Console.WriteLine("Write Yes or No");
                                Answer = Console.ReadLine();
                                if (Answer == "Yes")
                                {
                                    ReadyToCreateSecondBranch = true;
                                }
                                else if (Answer == "No")
                                {
                                    Console.WriteLine("You created your Family Tree");
                                    Console.WriteLine("Now you can watch your Family Tree,see information about exact person and change it");
                                    UsingBranchCreator = false;
                                }
                                if (ReadyToCreateSecondBranch)
                                {
                                    //Creating second child of first parents
                                    Console.WriteLine($"Now you need to create {Person0.name}'s and {Person1.name}'s second child");
                                    Console.WriteLine($"Write {Person0.name}'s and {Person1.name} second child name");
                                    Person3.name = Console.ReadLine();
                                    Console.WriteLine($"Write {Person3.name} BirthDate");
                                    Person3.BirthDate = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine($"Is {Person3.name} dead?\nWrite Yes or No");
                                    Answer = Console.ReadLine();
                                    if (Answer == "Yes")
                                    {
                                        Person3.IsDead = true;
                                        Console.WriteLine($"Write {Person3.name} DieDate");
                                        Person3.DieDate = Convert.ToInt32(Console.ReadLine());
                                    }
                                    else if (Answer == "No")
                                    {
                                        Person3.IsDead = false;
                                    }
                                    Person0.Child1Name = Person3.name;
                                    Person1.Child1Name = Person3.name;
                                    Person3.Parent0Name = Person0.name;
                                    Person3.Parent1Name = Person1.name;
                                    Person0.HaveChild1 = true;
                                    Person1.HaveChild1 = true;
                                    People++;
                        Console.WriteLine($"Does {Person3.name} have spouse");
                        Console.WriteLine("Write Yes or No");
                        Answer = Console.ReadLine();
                        if (Answer == "Yes")
                        {   
                            //Creating spouse of second child of first parents
                            Console.WriteLine($"Now you need to create {Person3.name}'s spouse");
                            Console.WriteLine($"Write {Person3.name}'s spouse name");
                            Person8.name = Console.ReadLine();
                            Console.WriteLine($"Write {Person8.name} BirthDate");
                            Person8.BirthDate = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Is {Person8.name} dead?\nWrite Yes or No");
                            Answer = Console.ReadLine();
                            if (Answer == "Yes")
                            {
                                Person8.IsDead = true;
                                Console.WriteLine($"Write {Person8.name} DieDate");
                                Person8.DieDate = Convert.ToInt32(Console.ReadLine());
                            }
                            else if (Answer == "No")
                            {
                                Person8.IsDead = false;
                            }
                            Person3.SpouseName = Person8.name;
                            Person8.SpouseName = Person3.name;
                            Person3.HaveSpouse = true;
                            Person8.HaveSpouse = true;
                            People++;
                            Console.WriteLine($"Do {Person3.name} and {Person8.name} have child?");
                            Console.WriteLine("Write Yes or No");
                            Answer = Console.ReadLine();
                            if (Answer == "Yes")
                            {
                                //Creating first child of third parents
                                Console.WriteLine($"Now you need to create {Person3.name}'s and {Person8.name}'s first child");
                                Console.WriteLine($"Write {Person3.name}'s and {Person8.name} first child name");
                                Person10.name = Console.ReadLine();
                                Console.WriteLine($"Write {Person10.name} BirthDate");
                                Person10.BirthDate = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine($"Is {Person10.name} dead?\nWrite Yes or No");
                                Answer = Console.ReadLine();
                                if (Answer == "Yes")
                                {
                                    Person10.IsDead = true;
                                    Console.WriteLine($"Write {Person10.name} DieDate");
                                    Person10.DieDate = Convert.ToInt32(Console.ReadLine());
                                }
                                else if (Answer == "No")
                                {
                                    Person10.IsDead = false;
                                }
                                Person3.Child0Name = Person10.name;
                                Person8.Child0Name = Person10.name;
                                Person10.Parent0Name = Person3.name;
                                Person10.Parent1Name = Person8.name;
                                Person3.HaveChild0 = true;
                                Person8.HaveChild0 = true;
                                People++;
                                Console.WriteLine($"Do {Person3.name} and {Person8.name} have second child?");
                                Console.WriteLine("Write Yes or No");
                                Answer = Console.ReadLine();
                                    if (Answer == "Yes")
                                    {
                                        //Creating second child of third parents
                                        Console.WriteLine($"Now you need to create {Person3.name}'s and {Person8.name}'s second child");
                                        Console.WriteLine($"Write {Person3.name}'s and {Person8.name} second child name");
                                        Person11.name = Console.ReadLine();
                                        Console.WriteLine($"Write {Person11.name} BirthDate");
                                        Person11.BirthDate = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Is {Person11.name} dead?\nWrite Yes or No");
                                        Answer = Console.ReadLine();
                                        if (Answer == "Yes")
                                        {
                                            Person11.IsDead = true;
                                            Console.WriteLine($"Write {Person11.name} DieDate");
                                            Person11.DieDate = Convert.ToInt32(Console.ReadLine());
                                        }
                                        else if (Answer == "No")
                                        {
                                            Person11.IsDead = false;
                                        }
                                        Person3.Child1Name = Person11.name;
                                        Person8.Child1Name = Person11.name;
                                        Person11.Parent0Name = Person3.name;
                                        Person11.Parent1Name = Person8.name;
                                        Person3.HaveChild1 = true;
                                        Person8.HaveChild1 = true;
                                        People++;
                                    Console.WriteLine($"Does {Person10.name} have spouse");
                                    Console.WriteLine("Write Yes or No");
                                    Answer = Console.ReadLine();
                                    if (Answer == "Yes")
                                    {
                                        //Creating spouse of first child of third parents
                                        Console.WriteLine($"Now you need to create {Person10.name}'s spouse");
                                        Console.WriteLine($"Write {Person10.name}'s spouse name");
                                        Person12.name = Console.ReadLine();
                                        Console.WriteLine($"Write {Person12.name} BirthDate");
                                        Person12.BirthDate = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine($"Is {Person12.name} dead?\nWrite Yes or No");
                                        Answer = Console.ReadLine();
                                        if (Answer == "Yes")
                                        {
                                            Person12.IsDead = true;
                                            Console.WriteLine($"Write {Person12.name} DieDate");
                                            Person12.DieDate = Convert.ToInt32(Console.ReadLine());
                                        }
                                        else if (Answer == "No")
                                        {
                                            Person12.IsDead = false;
                                        }
                                        Person10.SpouseName = Person12.name;
                                        Person12.SpouseName = Person10.name;
                                        Person10.HaveSpouse = true;
                                        Person12.HaveSpouse = true;
                                        People++;
                                        Console.WriteLine($"Does {Person11.name} have spouse");
                                        Console.WriteLine("Write Yes or No");
                                        Answer = Console.ReadLine();
                                        if (Answer == "Yes")
                                        {
                                            //Creating spouse of second child of third parents
                                            Console.WriteLine($"Now you need to create {Person11.name}'s spouse");
                                            Console.WriteLine($"Write {Person11.name}'s spouse name");
                                            Person13.name = Console.ReadLine();
                                            Console.WriteLine($"Write {Person13.name} BirthDate");
                                            Person13.BirthDate = Convert.ToInt32(Console.ReadLine());
                                            Console.WriteLine($"Is {Person13.name} dead?\nWrite Yes or No");
                                            Answer = Console.ReadLine();
                                            if (Answer == "Yes")
                                            {
                                                Person13.IsDead = true;
                                                Console.WriteLine($"Write {Person13.name} DieDate");
                                                Person13.DieDate = Convert.ToInt32(Console.ReadLine());
                                            }
                                            else if (Answer == "No")
                                            {
                                                Person13.IsDead = false;
                                            }
                                            Person11.SpouseName = Person13.name;
                                            Person13.SpouseName = Person11.name;
                                            Person11.HaveSpouse = true;
                                            Person13.HaveSpouse = true;
                                            People++;
                                        }
                                    }
                                    }
                                }
                            }
                        }
                    Console.Clear();
                                    Console.WriteLine("You created second branch of the Family Tree\nNow you cant create any more people because right now this program cant hold more people");
                                    Console.WriteLine("Now you can watch your Family Tree,see information about exact person and change it");
                                    UsingBranchCreator = false;
                                 
                                
                            
                        
                    
                }
            }
                    
            bool HavePeople = false;
            bool Using = true;
            Console.WriteLine("Family Tree");
            while (Using)
            {
                Console.WriteLine("Select function:\nShow family tree\nCreate branch of the tree\nSelect person\nQuit");
                switch (Console.ReadLine())
                {
                    case "Show family tree":
                        HavePeople = true;
                        Person0.name = "Olga";
                        Person1.name = "Rostislav";
                        if (HavePeople)
                            ShowFamilyTree();
                        else
                            Console.WriteLine("You need to create at least one branch of the tree first");
                        break;
                    case "Create branch of the tree":
                        UsingBranchCreator = true;
                        CreateBranch();
                        break;
                    case "Select person":
                        Console.Clear();
                        UsingSelectingPerson = true;
                        while (UsingSelectingPerson)
                        {
                            Console.WriteLine("Select function:\nShow Info\nChange Info\nQuit Select Person");
                            switch (Console.ReadLine())
                            {
                                case "Show Info":
                                    Console.WriteLine("Write name of the person which Info you want to see");
                                    Answer = Console.ReadLine();
                                    Console.Clear();
                                    ShowPeopleInfo();
                                    break;
                                case "Change Info":
                                    ChangePersonInfo();
                                    break;
                                case "Quit Select Person":
                                    UsingSelectingPerson = false;
                                    break;
                            }
                        }
                        break;                    
                    case "Quit":
                        Environment.Exit(0);
                        break;
                }
            }
            }
        }
    }