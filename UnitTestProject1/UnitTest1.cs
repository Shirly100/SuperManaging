﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using BE;
using BL;
using DS;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Mother m;
        Nanny nanny;
        Nanny n;
        public UnitTest1()
        {
             m = new Mother
            {
                Address = new Address { City = "Jerusalem", Street = "Beit Hadefus", HouseNumber = 7, Country = "Israel", Floor = 1, ZipCode = "zip" },
                ID = 123,
                FirstName = "Chany",
                LastName = "Cohen",
                Age = 25,
                Pelephone = "03455666",
                 WorkDays = new Dictionary<BE.Days, KeyValuePair<int, int>>()
            {
                {BE.Days.Sun, new KeyValuePair<int, int>(12,14 )},
                {BE.Days.Mon, new KeyValuePair<int, int>(12,14 )},
                {BE.Days.Tue, new KeyValuePair<int, int>(12,14 )},
                {BE.Days.Wed, new KeyValuePair<int, int>(12,14 )}
             },
                 Range = 50,
                 BankAccount = new BankAccount{AccountNumber = 100, Balance = 10000, BankName = "Leumi", BankNumber = 22, BranchAddress = new Address { City = "Jerusalem", Street = "Beit Hadefus", HouseNumber = 7, Country = "Israel", Floor = 1, ZipCode = "zip" }, BranchNumber = 65 },

             };
            nanny = new Nanny
            {
                ID = 2243,
                FirstName = "rivi",
                LastName = "bar",
                Age = 20,
                BankAccount = new BankAccount { AccountNumber = 200, Balance = 10, BankName = "Leumi", BankNumber = 22, BranchAddress = new Address { City = "Jerusalem", Street = "Beit Hadefus", HouseNumber = 7, Country = "Israel", Floor = 1, ZipCode = "zip" }, BranchNumber = 65 },
                Address = new Address { City = "Jerusalem", Street = "Beit Hadefus", HouseNumber = 11, Country = "Israel", Floor = 1, ZipCode = "zip" },
                BirthDate = new DateTime(1995,12,26),
                ExperienceYears = 0,
                HourlyRate = 27,
                MaxNumOfChildren = 5,
                MinAgeOfChild = 2,
                MonthlyRate = 1000,
                Elevator =true,
                WorkDays = new Dictionary<BE.Days, KeyValuePair<int, int>>()
            {
                {BE.Days.Sun, new KeyValuePair<int, int>(8,14 )},
                {BE.Days.Mon, new KeyValuePair<int, int>(8,14 )},
                {BE.Days.Tue, new KeyValuePair<int, int>(8,14 )},
                {BE.Days.Wed, new KeyValuePair<int, int>(8,14 )}
             }
            };
            n = new Nanny
            {
                ID = 243,
                FirstName = "rivi2",
                LastName = "bar2",
                Age = 20,
                BankAccount = new BankAccount { AccountNumber = 200, Balance = 10, BankName = "Leumi", BankNumber = 22, BranchAddress = new Address { City = "Jerusalem", Street = "Beit Hadefus", HouseNumber = 7, Country = "Israel", Floor = 1, ZipCode = "zip" }, BranchNumber = 65 },
                Address = new Address { City = "Jerusalem", Street = "Beit Hadefus", HouseNumber = 11, Country = "Israel", Floor = 1, ZipCode = "zip" },
                BirthDate = new DateTime(1995, 12, 26),
                ExperienceYears = 0,
                HourlyRate = 27,
                MaxNumOfChildren = 5,
                MinAgeOfChild = 2,
                MonthlyRate = 1000,
                Elevator = true,
                WorkDays = new Dictionary<BE.Days, KeyValuePair<int, int>>()
            {
                {BE.Days.Sun, new KeyValuePair<int, int>(13,14 )},
                {BE.Days.Mon, new KeyValuePair<int, int>(13,14 )},
                {BE.Days.Tue, new KeyValuePair<int, int>(13,14 )},
                {BE.Days.Wed, new KeyValuePair<int, int>(13,14 )}
             }
            };
            Child ch = new Child
            {
                Age = 3,
                Allergies = false,
                BirthDate = "01/08/2017",
                FirstName = "Leiky",
                ID_child = 1234,
                ID_Mother = 123,
                SpecialNeeds = true
            };
           
            Contract cccc = new Contract
            {
                ContractID = 100,
                ID_child = ch.ID_child,
                ID_nanny = n.ID,
                ID_mother = m.ID,
                StartDate = "15/11/2017"
            };
            Contract c = new Contract
            {
                ContractID = 100,
                ID_child = ch.ID_child,
                ID_nanny = n.ID,
                ID_mother = m.ID,
                StartDate = "15/10/2017"
            };
            factoryBL.get_bl().addMother(m);
            factoryBL.get_bl().addNanny(nanny);
            factoryBL.get_bl().addNanny(n);
            factoryBL.get_bl().addChild(ch);
            factoryBL.get_bl().addContract(cccc);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Child chil = new Child
            {
                Age = 5,
                Allergies = false,
                BirthDate = "01/08/2017",
                FirstName = "Leiky",
                ID_child = 1234,
                ID_Mother = 123,
                SpecialNeeds = true
            };
            foreach ( Mother i in DataSource.Mothers)
                Console.WriteLine(i.ToString());
            foreach (Nanny i in DataSource.Nannies)
                Console.WriteLine(i.ToString());
            foreach (Contract i in DataSource.contracts)
                Console.WriteLine(i.ToString());
            foreach (Child i in DataSource.Children)
                Console.WriteLine(i.ToString());
            Console.WriteLine("fffff");
            Mother upm = new Mother {ID = 123 };
            var result = factoryBL.get_bl();
            result.updateChild(chil);
            result.updateMother(upm);
            var t = result.Nannies_by_Children_Ages();
           // Console.WriteLine(nanny.ToString());
            foreach (var item in t)
            {
                Console.WriteLine(item.Key.ToString());
            }
        }
    }
}
