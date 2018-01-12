﻿using BaseModel;
using System.Collections.Generic;

namespace AndersonNotificationModel
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Receiver { get; set; }
    }
}