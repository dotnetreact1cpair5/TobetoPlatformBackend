﻿namespace Business.Dtos.Response.CreatedResponse
{
    public class CreatedAccountApplicationResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }

        public int ApplicationStepId { get; set; }
        public string DocumentName { get; set; }
    }
}
