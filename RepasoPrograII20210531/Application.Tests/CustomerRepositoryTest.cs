﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Application.Repositories;
using Application.Models;

namespace Application.Tests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        /// <summary>
        ///A test for Create
        ///</summary>
        [TestMethod()]
        public void CreateSuccessfullyTest()
        {
            //Arrange
            CustomerRepository repository = new CustomerRepository();

            int millisecond = DateTime.Now.Millisecond;

            Customer entityToCreate = new Customer()
            {
                LastName = "TestCustomerLastName" + millisecond,
                Name = "TestCustomerName" + millisecond
            };
            //Notar que entityToCreate.Id es null en este momento


            //Act
            repository.Create(entityToCreate);

            Customer entityToValidate =
                repository.GetById(entityToCreate.Id);

            //Assert
            Assert.IsNotNull(entityToValidate);
            Assert.IsTrue(entityToValidate.Id > 0);
        }

        ///// <summary>
        /////A test for GetAll
        /////</summary>
        [TestMethod()]
        public void GetAllTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada
            List<Customer> expected = new List<Customer>(); // TODO: Inicializar de manera apropiada
            List<Customer> actual = new List<Customer>();

            //Act
            actual = target.GetAll();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        ///// <summary>
        /////A test for GetById
        /////</summary>
        [TestMethod()]
        public void GetByIdTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada
            long entityId = 1;
            Customer expected = new Customer(); // TODO: Inicializar de manera apropiada 
            Customer actual;

            //Act
            actual = target.GetById(entityId);

            //Assert
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
        ///// <summary>
        /////A test for Remove
        /////</summary>
        [TestMethod()]
        public void RemoveTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada 
            Customer entity = new Customer();// TODO: Inicializar de manera apropiada
            entity.Id = 1;
            target.Remove(entity);
            Customer actual;

            //Act

            //Assert
            Assert.Inconclusive("A method that does not return a value cannot be verified.");

        }
        ///// <summary>
        /////A test for Update
        /////</summary>
        [TestMethod()]
        public void UpdateTest()
        {
            //Arrange
            CustomerRepository target = new CustomerRepository(); // TODO: Inicializar de manera apropiada 
            Customer entity = new Customer(); // TODO: Inicializar de manera apropiada 

            //Act
            target.Update(entity);

            //Assert
            Assert.Inconclusive("A method that does not return a value cannot be verified.");

        }
    }
}
