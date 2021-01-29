using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationManager; //generate constructor dedik alttaki geldi

        public GamerManager(IUserValidationService userValidationManager) //bu ben gamermanager içinde doğrulama sistemi kullanacağım demektir.
        {//constructordan verdiğim yapı set oldu
            _userValidationManager = userValidationManager;
        }

        //microservice gamermanager başka bir servis kullanacak
        public void Add(Gamer gamer)
        {
            if (_userValidationManager.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName +" "+ gamer.LastName + " regestered.");
            }
            else
            {
                Console.WriteLine("Verification failed, registration failed");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
