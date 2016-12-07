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
        Get["/contact/"] = _ => {
          return View["added_contact"];
        };
        Post["/contact/delete"] = _ => {
          return View["delete_contacts.cshtml"]
        };
        Get["/contact/see1contact"] = _ => {
          return View["single_contact.cshtml"];
        };
        Get["/contact/new"] = _ => {
          return View["add_new_contact"];
        };
        Get["/contacts/{id}"] = parameters => {
        Contact friend = Contact.Find(parameters.id);
        return View["contact.cshtml", friend];

      };

    }
