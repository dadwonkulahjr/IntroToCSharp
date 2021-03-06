﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToCSharp
{
    public interface IComax
    {
        #region IComax Interface Methods Implementation
        Person GetPerson(int id);
        IEnumerable<Person> GetListOfPerson();
        Person Delete(int id);
        Person Update(Person personChanges);
        int Count { get; }

        Person AddPerson(Person person);
        #endregion
    }
}
