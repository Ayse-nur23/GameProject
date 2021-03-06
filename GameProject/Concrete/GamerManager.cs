﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class GamerManager :IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kullanıcı kayıt edildi.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarız.Kayıt başarısız.");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı  silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı  güncellendi.");
        }
    }

}
