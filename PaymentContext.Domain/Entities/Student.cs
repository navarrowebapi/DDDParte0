using System;
using System.Collections.Generic;
using System.Linq;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class Student
    {

        private IList<Subscription> _subscriptions;
        public Student(Name name, string document, string email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        }

        public Name Name { get; set; }
        public String Document { get; private set; }
        public String Email { get; private set; }
        public String Address { get; private set; }
        // public List<Subscription> Subscriptions { get; set; }
         public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }

        //inicialmente assim, vai dar pau, pois nao temos Add para IReadl
        public void AddSubscription(Subscription subscription){
            foreach (var item in Subscriptions)
            {
                item.Active = false;
            }
            _subscriptions.Add(subscription);
        }
    }
}