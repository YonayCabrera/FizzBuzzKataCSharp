using System.Runtime.Remoting;
using NSubstitute;
using NUnit.Framework;

using testDoubleKata.repository;
using testDoubleKata.entity;
using testDoubleKata.services;


namespace testDoubleKata.test.services{
    
    [TestFixture]
    public class CreateCustomerShould{

        [Test]
        public void Save_a_customer(){
            //given
            Customer customer = new Customer();
            CustomerRepository customerRepository = Substitute.For<CustomerRepository>();
            CreateCustomer createCustomer = new CreateCustomer(customerRepository);
            //when
            createCustomer.Execute(customer);
            //then
            customerRepository.Received().save(customer);
        }
    }
}
