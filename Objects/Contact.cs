using System.Collections.Generic;


namespace NewAddressBook.Objects
{
  public class Contact
    {
        private string _person;
        private string _address;
        private string _number;


        private static List<Contact> _outcome = new List<Contact> {};

        public Contact (string newPerson, string newAddress, string newNumber)
      {

        _person = newPerson;

        _address = newAddress;

        _number = newNumber;

        _count = _outcome.Count;

        _outcome.Add(this);
      }

      public static List<Contact> GetAll()
      {
        return _outcome;
      }

      public string FriendPerson()
      {
        return _person;
      }

      public string FriendAddress()
      {
        return _address;
      }

      public string FriendNumber()
      {
          return _number;

      }

      public string CounterId()
      {
        return _id;
      }

      public static void ClearAll()
      {
        _outcome.Clear();
      }

      public static Contact Find(int Idc)
      {
        return _outcomes[Idc - 1];
      }
    }
  }
}
