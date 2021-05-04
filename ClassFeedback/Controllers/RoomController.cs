using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassFeedback.Modeles;

namespace ClassFeedback.Controllers
{
    public class RoomController : Controller
    {
        List<Message> chatLog = new List<Message>();
        public IActionResult Index(int id)
        {
            // Default user created for admin messaging from the "Room Bot"
            RoomOwner RoomBot = new RoomOwner() { FirstName = "Room", LastName = "Bot", BackgroundColor = "Grey" };

            // Hard Coded Room creation for testing only TODO: Remove this default room
            Room test = new Room(RoomBot, 0);

            // Initial Chat Message
            chatLog.Add(new Message() { PostDateTime = DateTime.Now, Author = RoomBot, AnonymousMessage = false, MessageText = "Welcome to chat." });
            ViewBag.RoomID = id;
            return View(chatLog);
        }
    }
}
