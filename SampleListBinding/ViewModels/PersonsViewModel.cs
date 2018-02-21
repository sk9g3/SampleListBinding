using SampleListBinding.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SampleListBinding.ViewModels
{
    public class PersonsViewModel:ViewModelBase
    {
        private ObservableCollection<Person> persons;

        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set
            {
                persons = value;
                OnPropertyChanged();
            }
        }

        public PersonsViewModel()
        {
            GetPerson();
        }

        public void GetPerson()
        {
            Persons = new ObservableCollection<Person>();
            for(byte i =0; i< 20; i++)
            {
                Person p = new Person();
                p.FirstName = $"Person FirstName {i}";
                p.FirstName = $"LastName {i}";
                Persons.Add(p);
            }
        }

    }
}
