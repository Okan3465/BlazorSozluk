using BlazorSozluk.Common.Models.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSozluk.Common.Models.RequestModels
{
    public class LoginUserCommand : IRequest<LoginUserViewModel>  /*LoginUserViewModel  dışarı dönecek değerler*/
    {
        public string EmailAddress { get; set; }  //Dışarıdan alınacak değer
        public string Password { get;set; }    //Dışarıdan alınacak değer

        public LoginUserCommand(string emailAddress, string password)
        {
            EmailAddress = emailAddress;
            Password = password;
        }
        public LoginUserCommand()
        {

        }
    }
}
