﻿namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedSurveyResponse
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public int SurveyTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public DateTime PublishedDate { get; set; }

    }

}
