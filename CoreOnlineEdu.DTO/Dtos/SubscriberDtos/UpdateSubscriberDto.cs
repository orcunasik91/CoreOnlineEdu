﻿namespace CoreOnlineEdu.DTO.Dtos.SubscriberDtos;
public class UpdateSubscriberDto
{
    public int SubscriberId { get; set; }
    public string Email { get; set; }
    public bool IsActive { get; set; }
}