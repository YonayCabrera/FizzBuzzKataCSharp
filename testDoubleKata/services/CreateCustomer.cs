using testDoubleKata.entity;
using testDoubleKata.repository;

namespace testDoubleKata.services{
    public class CreateCustomer{

        private CustomerRepository customerRepository;
        public CreateCustomer(CustomerRepository customerRepository){
            this.customerRepository = customerRepository;
        }

        public void Execute(Customer customer){
            customerRepository.save(customer);
        }
    }
}