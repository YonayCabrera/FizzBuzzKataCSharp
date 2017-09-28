using System;
using NUnit.Framework;
using testDoubleKata.entity;
using testDoubleKata.repository;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace testDoubleKata.test.repository{
    
    [TestFixture]
    [Ignore("Ignore a fixture")]
    public class CustomerRepositoryShould{

        private SqlConnection sqlConnection;
        [SetUp]
        public void SetUp(){
            sqlConnection = new SqlConnection("Server = postgres;" +
                                              "Database =doubleTest;" +
                                              "User ID=postgres;Password=1234; ");
        }
        //jdbc:postgresql://localhost:5432/testdb
        
        [Test]
        public void Save_a_customer(){
            //given
            CustomerRepositoryPostgresql customerRepositoryPostgresql =
                new CustomerRepositoryPostgresql(sqlConnection);
            Customer customer = new Customer("yonay");
            
            //when
            CreateCustomersTable();
            customerRepositoryPostgresql.Save(customer);
            Customer newCustomer = new Customer(GetCustomer());
            //then
            Assert.AreEqual(customer.getName(),newCustomer.getName());
        }

        private string GetCustomer(){
            SqlDataReader sqlDataReader = new SqlCommand("SELECT * FROM customers").ExecuteReader();
            while (sqlDataReader.Read()){
                return (string) sqlDataReader[0];
            }
            return null;
        }

        private void CreateCustomersTable(){
            try{
                new SqlCommand("CREATE TABLE IF NOT EXISTS public.customers\n" +
                               "(\n" +
                               "  ID SERIAL,\n" +
                               "  NAME VARCHAR(20) NOT NULL,\n" +
                               ")",sqlConnection);

            }
            catch (Exception e){
                
            }
        }

    }
}