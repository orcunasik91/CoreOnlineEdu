namespace CoreOnlineEdu.DTO.Dtos.MessageDtos;
public class UpdateMessageDto
{
    public int MessageId { get; set; }
    public string SenderName { get; set; }
    public string Email { get; set; }
    public string Subject { get; set; }
    public string Content { get; set; }
}