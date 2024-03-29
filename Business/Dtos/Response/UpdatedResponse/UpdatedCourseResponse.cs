﻿namespace Business.Dtos.Response.UpdatedResponse
{
    public class UpdatedCourseResponse
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int CategoryId { get; set; }
        public int OrganizationId { get; set; }
        public int ContentTypeId { get; set; }
        public int PathFileId { get; set; }
        public string Name { get; set; }
        public string EstimatedVideoDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
