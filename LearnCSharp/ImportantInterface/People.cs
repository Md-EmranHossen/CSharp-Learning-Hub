using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportantInterface
{
    public class People : IEnumerable<Person>, ICollection<Person>
    {
        private Person[] _person;
        private int _index;

        public People()
        {
            _index = 0;
        }


        private Person[] _persons;


        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => true;

        public IEnumerator<Person> GetEnumerator()
        {
            return new PeopleEnumerator(_persons);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Person item)
        {
            if( _index<_persons.Length )
            _persons[_index++] = item;
        }

        public void Clear()
        {
            _index = 0;
        }

        public bool Contains(Person item)
        {
            foreach (Person p in _person)
                if (p.Equals(item))
                    return true;

            return false;
        }

        public void CopyTo(Person[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Person item)
        {
            throw new NotImplementedException();
        }
    }
}
