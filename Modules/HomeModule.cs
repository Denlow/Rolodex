using System.Collections.Generic;
using NewAddressBook.Objects;
using Nancy;

namespace NewAddressBook
{
  public class HomeModule : NancyModule
    {
      public HomeModule()
      {
        Get["/"] = _ => {
          List<Contact> ourRolodex = Contact.GetAll();
          return View["index.cshtml", ourRolodex];
        };
        Get["/contact/new"] = _ => {
          return View[""];
        };
        Get[""] = _ => {
        };
        Post["/contact/add_friend"] = _ => {
          return View[""]
        }
    }
