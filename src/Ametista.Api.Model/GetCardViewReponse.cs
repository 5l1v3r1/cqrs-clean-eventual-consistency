﻿using System;

namespace Ametista.Api.Model
{
    public class GetCardViewReponse
    {
        public string CardHolder { get; set; }

        public DateTime ExpirationDate { get; set; }

        public Guid Id { get; set; }

        public string Number { get; set; }
    }
}