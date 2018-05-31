using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot
                ("自己的 Channel access token");
            bot.PushMessage("Your user ID", "Test");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot
                ("自己的 Channel access token");
            bot.PushMessage("Your user ID", 1, 113);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            isRock.LineBot.Bot bot = new isRock.LineBot.Bot
                ("自己的 Channel access token");
            bot.PushMessage("Your user ID", new Uri("https://s2.fafa01.com/uploads/06/2/310228/14973227133525.jpg"));
        }
    }
}