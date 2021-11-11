using System;

public class CalendarEvent{
    public DateTime? CreatedOn { get; set; } = null;
    public Guid EventID { get; set; }
    public string EventName { get; set; }
    public DateTime EventInLocal { get; set; }

    public string EventColor { get; set; } = "bg-gray-500 dark:bg-gray-400";
    public Priority EventPriority { get; set; } = Priority.LOW;
    public string EventOwner { get; set; } = System.Environment.UserName;

    public DateTime EventInUTC {

        get{
            return EventInLocal.ToUniversalTime();
        }
    }
    
    public string EventDisplayFormat {
        get{
            return $"{EventName} {EventOwner} {EventPriority}";
        }
    }
}