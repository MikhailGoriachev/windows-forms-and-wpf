using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataGridSample
{
    public enum OrderStatus 
    {
        InProgress, Delivered
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsMember { get; set; }
        public OrderStatus Status { get; set; }

        public static ObservableCollection<Customer> GetCustomerList() {
            ObservableCollection<Customer> collection = new ObservableCollection<Customer> {
                new Customer() {
                    FirstName = "Jhon",
                    LastName  = "Doe",
                    Email     = "jhon.doe@mail.com",
                    IsMember  = true,
                    Status    = OrderStatus.InProgress
                },
                new Customer() {
                    FirstName = "Joe",
                    LastName  = "Doe",
                    Email     = "joe.doe@mail.com",
                    IsMember  = true,
                    Status    = OrderStatus.InProgress
                },
                new Customer() {
                    FirstName = "Уилл",
                    LastName  = "Смит",
                    Email     = "agent.w@mail.com",
                    IsMember  = true,
                    Status    = OrderStatus.Delivered
                },
                new Customer() {
                    FirstName = "Харли",
                    LastName  = "Квин",
                    Email     = "quenn.h@pudding.com",
                    IsMember  = true,
                    Status    = OrderStatus.InProgress
                }
            };
            return collection;
        }
    }

    

}
