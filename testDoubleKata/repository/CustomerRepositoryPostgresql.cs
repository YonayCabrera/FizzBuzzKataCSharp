using System.ComponentModel.Design;
using System.Data.SqlClient;
using testDoubleKata.entity;

namespace testDoubleKata.repository{
    public class CustomerRepositoryPostgresql{

        private SqlConnection connection;
        public CustomerRepositoryPostgresql(SqlConnection connection){
            this.connection = connection;
        }

        public void Save(Customer customer){
            connection.Open();
            new SqlCommand("INSERT INTO customers(name) VALUES ("+customer.getName()+")",connection);
        }
    }
}