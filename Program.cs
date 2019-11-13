using System;

namespace StringPractice {
  class Program {
    static void Main (string[] args) {
      var firstName = "Joe";
      var lastName = "Black";

      var fullName = firstName + " " + lastName;
      var fullName2 = string.Format ("My name is {0} {1}", firstName, lastName);
      var names = new string[3] { "John", "Jack", "Jo" };
      var formattedNames = string.Join (",", names);
      Console.WriteLine (formattedNames);
    }

  }
}