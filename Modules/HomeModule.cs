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
          foreach(var contact in currentRolodex)
          return View["index.cshtml", ourRolodex];
        };
        Get["/contact/new"] = _ => {
          return View["/add_new_contact", ];
        };
        Get[""] = _ => {
        };
        Post[""] = _ => {
          return View[""]
        }
    }
